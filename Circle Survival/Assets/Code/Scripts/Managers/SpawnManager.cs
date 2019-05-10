using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float SpawnTimer = 0;

    public GameParameters GameParameters;
    public RuntimeSet AvailableGreenBombs;
    public RuntimeSet AvailableBlackBombs;

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
        GameObject bombToSpawn = Random.Range(0f, 1f) > 0.2 ? AvailableGreenBombs.Get() : AvailableBlackBombs.Get();
        if (bombToSpawn == null)
            return;
        float xPos;
        float yPos;
        float explodeTime = Random.Range(GameParameters.MinExplodeTime, GameParameters.MaxExplodeTime);
        //TODO naprawic problem - po skonczeniu animacji bomby zostaje jej rozmiar ~= 0
        //w tym momencie zhardcodowany bombsize
        //float bombSize = bombToSpawn.GetComponent<SpriteRenderer>().bounds.size.x;
        float bombSize = 1.5f;
        //Debug.Log("Wielkosc bonby: " + bombSize);
        bool spaceClear;
        do
        {
            xPos = Random.Range(
                Camera.main.ScreenToWorldPoint(Vector2.zero).x + bombSize / 2.0f, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - bombSize / 2.0f
                );
            yPos = Random.Range(
                Camera.main.ScreenToWorldPoint(Vector2.zero).y + bombSize / 2.0f, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y - bombSize / 2.0f
                );
            spaceClear = Physics2D.OverlapCircle(new Vector2(xPos, yPos), 0.5f, 1 << 8) == null;
        } while (!spaceClear);

        bombToSpawn.transform.position = new Vector2(xPos, yPos);
        bombToSpawn.GetComponent<BombController>().ExplodeTime = explodeTime;
        bombToSpawn.SetActive(true);
    }
}
