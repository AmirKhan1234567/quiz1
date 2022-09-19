using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmermove : MonoBehaviour
{
	public float horizontalInput;
	public float speed = 10.0f;
	public float xRange = 13.05f;
	public GameObject projectilePrefab;
	[SerializeField] private float farmerspeed;
	[SerializeField] private Animator farmerAnim;
	private bool GameOver = false;

	private soundManager healthminus;
    private void Start()
    {
		healthminus = GameObject.Find("soundManager").GetComponent<soundManager>();
    }
    void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * Time.deltaTime * farmerspeed * horizontalInput);
			if (transform.position.x < -xRange)
		{
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
		if (horizontalInput != 0)
		{
			if (!farmerAnim.GetCurrentAnimatorStateInfo(0).IsName("run")) ;
			farmerAnim.SetTrigger("run");
		}
        else
        {
            if (!farmerAnim.GetCurrentAnimatorStateInfo(0).IsName("idle")) ;
            farmerAnim.SetTrigger("idle");
        }
        if (Input.GetKeyDown(KeyCode.Space))
		{
			if (!farmerAnim.GetCurrentAnimatorStateInfo(0).IsName("fire")) ;
			{
				farmerAnim.SetTrigger("fire");
				Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
			}
		}
	 }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("balls") && !GameOver)
        {
			soundManager.instance.healthloss();
			if (healthminus.health <= 0)
            {
				GameOver = true;
				Destroy(gameObject);
            }
		}
		 }
}
