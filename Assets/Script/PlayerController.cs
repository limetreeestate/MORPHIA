using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public Player player;

    public void forward()
    {
        player.forward();
    }

    public void backward()
    {
        player.backward();
    }

    public void jump()
    {
        player.jump();
    }

    public void stop()
    {
        player.stop();
    }

    public void reset()
    {
        player.reset();
    }

    public void setCheckpoint(Checkpoint c)
    {
        player.setLastCheckpoint(c);
    }


}
