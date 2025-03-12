
using UnityEngine;

public class AimAndShoot : MonoBehaviour 

{   
    [SerializeField] private float aimSpeed;
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private Transform playerTransform,shootPosition;
    private Camera cam; 
    private Vector2 mouseWorldPosition;
    void Start()
    {
        cam = Camera.main;
    }

   
    void Update()
    {
        transform.position = playerTransform.position;
        Aim();
        Shoot();
        

        
    }

    private void Aim()
    {
        mouseWorldPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mouseWorldPosition -(Vector2)transform.position;
        transform.right =  Vector2.MoveTowards(transform.right,direction,aimSpeed * Time.deltaTime);
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(arrowPrefab,shootPosition.position,Quaternion.identity);
        }
    }
}
