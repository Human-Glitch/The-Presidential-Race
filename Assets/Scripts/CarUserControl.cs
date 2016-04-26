using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
		public Canvas pauseCanvas;


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
			//pauseCanvas.enabled = false;
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif

			//Pause menu control
			if (Input.GetKeyDown (KeyCode.Escape)) {
				print ("PAUSED!");
				Time.timeScale = 0;
				pauseCanvas.enabled = true;

			}
        }
    }
}
