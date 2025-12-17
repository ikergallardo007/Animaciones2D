using UnityEngine;
using System;

public class LinkAnimatorController : MonoBehaviour
{    
    #region Properties
	#endregion

	#region Fields
	[SerializeField] private Animator _animator;
	[SerializeField] private SpriteRenderer _spriteRenderer;
	// [SerializeField] private SpriteRenderer _effectSpriteRenderer;
	#endregion

	#region Unity Callbacks
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Set Animator properties state
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			_animator.SetBool("Run", true);
            _spriteRenderer.flipX = false;
        }
			
		if (Input.GetKeyUp(KeyCode.RightArrow))
			_animator.SetBool("Run", false);

		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			_animator.SetBool("Run", true);
            _spriteRenderer.flipX = true;
        }

		if (Input.GetKeyUp(KeyCode.LeftArrow))
			_animator.SetBool("Run", false);

        if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			//_effectSpriteRenderer.flipX = _spriteRenderer.flipX;
			_animator.SetTrigger("Attack");
        }

		if (Input.GetKeyDown(KeyCode.UpArrow))
			_animator.SetTrigger("Jump");

		if (Input.GetKeyDown(KeyCode.Space))
		{
			_animator.SetTrigger("Dash");
			_animator.SetBool("Run", false);
        }

		if (Input.GetKeyDown(KeyCode.T))
		{
			_animator.SetTrigger("Teleport");
			_animator.SetBool("Run", false);
        }

		if (Input.GetKeyDown(KeyCode.DownArrow))
			_animator.SetTrigger("Hit");

    }
	#endregion

	#region Public Methods
	#endregion

	#region Private Methods
	#endregion
}
