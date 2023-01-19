using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : DefaultEnemy
{
    public override void SetEnemyInformation(int type, int health, float speed, Color _color)
    {
        EnemyType = type;
        Health = health;
        Speed = speed;
        GetComponent<MaterialSpecification>().SetColor(_color);
    }

    public override void OnEnable()
    {
        StartCoroutine(StartMove());
    }


    public override IEnumerator StartMove()
    {
        while (Health > 0)
        {
            transform.Translate(Vector3.forward * -Speed * Time.deltaTime);
            yield return null;
        }
        Dead(10);
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndLine") || other.CompareTag("Player"))
        {
            ReachendLine(-5);
        }
        else if (other.CompareTag("Bullet"))
        {
            Health-= other.GetComponent<Bullet>().Damage;
            if(Health<=0)
            {
                Dead(10);
            }
        }
    }

    public override  void ReachendLine(int score)
    {
        DependencyManager.OnEnemyHitEndLine(score);
        gameObject.SetActive(false);
    }

    public override void Dead(int score)
    {
        DependencyManager.OnEnemyDied(score);
        gameObject.SetActive(false);
    }

    public override void OnDisable()
    {
        StopAllCoroutines();
    }
}
