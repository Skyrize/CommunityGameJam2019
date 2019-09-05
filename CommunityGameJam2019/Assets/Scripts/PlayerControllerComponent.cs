using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerControllerComponent : MonoBehaviour
{
    [Header("References")]
    public GameObject gun;
    //public Tilemap map;

    //public void becomeInsane()
    //{
    //    map.RefreshAllTiles();
    //}

    //public void becomeSane()
    //{

    //}

    public void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            gun.GetComponent<GunComponent>().Fire();
        }
        if (Input.GetKeyDown(KeyCode.O)) {
            GetComponent<SanityComponent>().GetHealed(10);
        }
        if (Input.GetKeyDown(KeyCode.P)) {
            GetComponent<SanityComponent>().GetDamaged(10);
        }
        GetComponent<CharacterMovementComponent>().Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
