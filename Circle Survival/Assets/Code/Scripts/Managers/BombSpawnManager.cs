using UnityEngine;

//Gdy aktywny spawnuje na ekranie okresowo obiekty z RuntimeSetow
//Jesli nie ma wolnego obiektu to nie spawnuje nic (kolejny nie zmiescilby sie na ekranie)
public class BombSpawnManager : MonoBehaviour
{
    public float SpawnTimer = 0;

    public GameParameters GameParameters;
    public RuntimeSet AvailableGreenBombs;
    public RuntimeSet AvailableBlackBombs;

    //Wyczyszczenie setow z poprzednich wypelnien
    private void Awake()
    {
        AvailableBlackBombs.Clear();
        AvailableGreenBombs.Clear();
    }

    void Update()
    {
        SpawnTimer += Time.deltaTime;
        if(SpawnTimer > GameParameters.SpawnTime)
        {
            SpawnTimer = 0;
            SpawnBomb();
        }
    }

    private void SpawnBomb()
    {
        //Losowanie bomby do spawnu
        GameObject bombToSpawn = Random.Range(0f, 1f) > 0.15 ? AvailableGreenBombs.Get() : AvailableBlackBombs.Get();
        if (bombToSpawn == null)    //Jeśli nie ma wolnej bomby - zakończ
            return;
        float xPos;
        float yPos;
        float explodeTime = Random.Range(GameParameters.MinExplodeTime, GameParameters.MaxExplodeTime);
        float bombRadius = bombToSpawn.GetComponent<Transform>().localScale.x / 2.0f;
        bool spaceClear;
        //Szukanie wolnego miejsca na ekranie
        do
        {
            xPos = Random.Range(
                Camera.main.ScreenToWorldPoint(Vector2.zero).x + bombRadius, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - bombRadius
                );
            yPos = Random.Range(
                Camera.main.ScreenToWorldPoint(Vector2.zero).y + bombRadius, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y - bombRadius
                );
            spaceClear = Physics2D.OverlapCircle(new Vector2(xPos, yPos), bombRadius, 1 << 8) == null;
        } while (!spaceClear);
        //Ustawienie parametrów bomby i aktywacja obiektu
        bombToSpawn.transform.position = new Vector2(xPos, yPos);
        bombToSpawn.GetComponent<BombController>().ExplodeTime = explodeTime;
        bombToSpawn.SetActive(true);
    }
}
