using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject DeathParticlesPrefab = null;

    public bool ShouldDestroyOnDeath = true;

    [SerializeField] private float _HealthPoints = 100f;

    public float HealthPoints{
        get{
            return _HealthPoints;
        }

        set {
            _HealthPoints = value;
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            HealthPoints = 0;
        }
    }
}
