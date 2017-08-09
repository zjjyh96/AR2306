using UnityEngine;
using System.Collections;

public class GlobalVariable : MonoBehaviour {

    public static int score = 0;
    public static double[] timeRecords={0,0,0,0,0,0};
    public static float playTime = 0f;
    public static bool isGameEnd = false;

    // public void test()
    // {
    //     print(score);
    // }

    public void myUpdate(Rigidbody rb, Transform tf, float hori, float vert, int speed)
    {
        Vector3 pos = tf.position;
        pos.x += hori * speed * Time.deltaTime;
        pos.z += vert * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 0, 0);
            pos.y = 40.0F;
        }
        tf.position = pos;
    }

    public bool myQuadCtlnColDetection()
    {
        return false;
    }

    public void myCollisionBehavior()
    {

    }

    // return i th time record
    public double returnTimeRecords(int i)
    {
        return timeRecords[i];
    }

    // return current score
    public int returnScore()
    {
        return score;
    }

    // return current playtime
    public float returnPlayTime()
    {
        return playTime;
    }
    public void initPlayTime()
    {
        playTime=0f;
        isGameEnd=false;
    }

    public void insertTimeRecords(float newRec)
    {
        int n=4;
        while (n>=0) 
            if(timeRecords[n]==0) n--;
            else break;
        if (n>0)
        while (timeRecords[n]>newRec)
        {
            timeRecords[n+1]=timeRecords[n];
            n--;
        }
        timeRecords[n+1]=newRec;
    }
    public bool returnIsGameEnd()
    {
        return isGameEnd;
    }

    // add score when get a coin
    public void getScore()
    {
        score++;
    }

    void Update()
    {   
        if (score!=2)playTime+=Time.deltaTime;
        else if (score==2) 
        {
            isGameEnd=true;
            insertTimeRecords(playTime);
        }
        Debug.Log(score);
    }

}
