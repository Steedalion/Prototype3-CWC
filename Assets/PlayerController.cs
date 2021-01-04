using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	public ParticleSystem death;
	public AudioClip deatSound;
	public ParticleSystem dirt;
	public AudioClip jumpSound;
	InputController input;
	public float jumpForce = 100f;
	public float gravityModifier = 10f;
	Rigidbody rb;
	[SerializeField] bool isGrounded;
	public bool gameOver = false;
	Animator anim;
	public AudioSource playerAudio;
	// Awake is called when the script instance is being loaded.
	protected void Awake()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
		input = new InputController();
		input.PlayerWalking.Jump.performed += push => Jump();
		Physics.gravity *= gravityModifier;
		playerAudio = GetComponent<AudioSource>();
	}
	// This function is called w hen the object becomes enabled and active.
	protected void OnEnable()
	{
		input.Enable();
	}
	// This function is called when the behaviour becomes disabled () or inactive.
	protected void OnDisable()
	{
		input.Disable();
	}

	void Jump()
	{
		Debug.Log("Jumped");
		if (!gameOver && isGrounded)
		{
			anim.SetTrigger("Jump_trig");
			rb.AddForce(jumpForce*transform.up);
			playerAudio.PlayOneShot(jumpSound);
		}
	}
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	protected void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.other.CompareTag("Ground"))
		{
			isGrounded = true;
			dirt.Play();
		}
		if(collisionInfo.other.CompareTag("Obstacle"))
		{
			gameOver = true;
			anim.SetInteger("DeathType_int", 1);
			anim.SetBool("Death_b", true);
			death.Play();
			dirt.Stop();
			playerAudio.PlayOneShot(deatSound);
			Debug.Log("Game over");
		}
	}

	protected void OnCollisionExit(Collision collisionInfo)
	{
		if(collisionInfo.other.CompareTag("Ground"))
		{
			isGrounded = false;
			dirt.Stop();
		}
	}
}
