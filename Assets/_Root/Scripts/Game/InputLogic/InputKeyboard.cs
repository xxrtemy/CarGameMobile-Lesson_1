using UnityEngine;


namespace Game.InputLogic
{
    internal class InputKeyboard : BaseInputView
    {
        [SerializeField] private float InputMultiplier = 0.15f;
        
        
        protected override void Move()
        {
            float moveValue = Speed * InputMultiplier * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftArrow))
                OnLeftMove(moveValue);
            if (Input.GetKey(KeyCode.RightArrow))
                OnRightMove(moveValue);
        }



    }
}