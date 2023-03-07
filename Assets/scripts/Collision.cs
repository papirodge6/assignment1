using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    /* public void OnCollisionEnter2d (Collision2D col)
      {
          if(col.gameObject.name == "Hole")
          {
              Debug.Log("Contratulations you've won");
          }    
      }

      private void OnCollisionStay2d (Collision2D col)
      {
          if (col.gameObject.name == "Hole")
          {
              Debug.Log("Contratulations you've won");
          }
      }

      private void OnCollisionExit2d (Collision2D col)
      {
          if (col.gameObject.name == "Hole")
          {
              Debug.Log("Contratulations you've won");
          }
      }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Hole")
        {
            Debug.Log("Contratulations you've won");
        }
    }
}
