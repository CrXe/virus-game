using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MutationCordinator : MonoBehaviour {



	public SaveSc savesc;
	public Toggle shieldtoggle0;
	public Toggle shieldtoggle1;
	public Toggle shieldtoggle2;
	public Toggle shieldtoggle3;

	public Toggle magnettoggle0;
	public Toggle magnettoggle1;
	public Toggle magnettoggle2;
	public Toggle magnettoggle3;

	public Toggle dmgRedux0;
	public Toggle dmgRedux1;
	public Toggle dmgRedux2;
	public Toggle dmgRedux3;

	public Toggle noenemytoggle0;
	public Toggle noenemytoggle1;
	public Toggle noenemytoggle2;
	public Toggle noenemytoggle3;

	public Toggle pushertoggle0;
	public Toggle pushertoggle1;
	public Toggle pushertoggle2;
	public Toggle pushertoggle3;

	public Toggle takealltoggle0;
	public Toggle takealltoggle1;
	public Toggle takealltoggle2;
	public Toggle takealltoggle3;

	public Toggle movelevel1toggle;
	public Toggle movelevel2toggle;

	//Buttons

	public Button shieldbutton;
	public Button dmgReduxButton;
	public Button takeAllButton;
	public Button noEnemyButton;
	public Button pusherButton;
	public Button magnetButton;
	public Button dashButton;
	public Button squezeButton;

	void Start ()
	{


		shieldtoggle0.interactable = false;
		shieldtoggle1.interactable = false;
		shieldtoggle2.interactable = false;
		shieldtoggle3.interactable = false;

		magnettoggle0.interactable = false;
		magnettoggle1.interactable = false;
		magnettoggle2.interactable = false;
		magnettoggle3.interactable = false;

		dmgRedux0.interactable = false;
		dmgRedux1.interactable = false;
		dmgRedux2.interactable = false;
		dmgRedux3.interactable = false;

		noenemytoggle0.interactable = false;
		noenemytoggle1.interactable = false;
		noenemytoggle2.interactable = false;
		noenemytoggle3.interactable = false;

		pushertoggle0.interactable = false;
		pushertoggle1.interactable = false;
		pushertoggle2.interactable = false;
		pushertoggle3.interactable = false;

		takealltoggle0.interactable = false;
		takealltoggle1.interactable = false;
		takealltoggle2.interactable = false;
		takealltoggle3.interactable = false;

		movelevel1toggle.interactable = false;
		movelevel2toggle.interactable = false;
		Fakeupdate ();

		shieldbutton.interactable = true;
		dmgReduxButton.interactable= false;
		takeAllButton.interactable= false;
		noEnemyButton.interactable= false;
		pusherButton.interactable= false;
		magnetButton.interactable= false;
		dashButton.interactable= false;
		squezeButton.interactable= false;




		// Burada saveden bilgileri alıp preload yapılıyor
		switch (savesc.shieldpr) {
		case 1:
			shieldtoggle0.isOn = true;

			savesc.protein += 1;
			break;
		case 2:
			shieldtoggle0.isOn = true;
			shieldtoggle1.isOn = true;
			savesc.protein += 3;
			break;
		case 3:
			shieldtoggle0.isOn = true;
			shieldtoggle1.isOn = true;
			shieldtoggle2.isOn = true;
			savesc.protein += 6;
			break;
		case 4:
			shieldtoggle0.isOn = true;
			shieldtoggle1.isOn = true;
			shieldtoggle2.isOn = true;
			shieldtoggle3.isOn = true;

			savesc.protein += 10;
			break;
			}

		switch (savesc.magnetpr) {
		case 1:
			magnettoggle0.isOn = true;
			savesc.protein += 2;
	
			break;
		case 2:
			magnettoggle0.isOn = true;
			magnettoggle1.isOn = true;
			savesc.protein += 5;

			break;
		case 3:
			magnettoggle0.isOn = true;
			magnettoggle1.isOn = true;
			magnettoggle2.isOn = true;
			savesc.protein += 9;

			break;
		case 4:
			magnettoggle0.isOn = true;
			magnettoggle1.isOn = true;
			magnettoggle2.isOn = true;
			magnettoggle3.isOn = true;
			savesc.protein += 14;
			break;
		}
		switch (savesc.squezepr) {
		case 1:
			dmgRedux0.isOn = true;
			savesc.protein += 2;
			break;
		case 2:
			dmgRedux0.isOn = true;
			dmgRedux1.isOn = true;
			savesc.protein += 5;
			break;
		case 3:
			dmgRedux0.isOn = true;
			dmgRedux1.isOn = true;
			dmgRedux2.isOn = true;
			savesc.protein += 9;
			break;
		case 4:
			dmgRedux0.isOn = true;
			dmgRedux1.isOn = true;
			dmgRedux2.isOn = true;
			dmgRedux3.isOn = true;
			savesc.protein += 14;
			break;
		}
		switch (savesc.noenemypr) {
		case 1:
			noenemytoggle0.isOn = true;
			savesc.protein += 2;
			break;
		case 2:
			noenemytoggle0.isOn = true;
			noenemytoggle1.isOn = true;
			savesc.protein += 5;
			break;
		case 3:
			noenemytoggle0.isOn = true;
			noenemytoggle1.isOn = true;
			noenemytoggle2.isOn = true;
			savesc.protein += 9;
			break;
		case 4:
			noenemytoggle0.isOn = true;
			noenemytoggle1.isOn = true;
			noenemytoggle2.isOn = true;
			noenemytoggle3.isOn = true;
			savesc.protein += 14;
			break;
		}
		switch (savesc.pusherpr) {
		case 1:
			pushertoggle0.isOn = true;
			savesc.protein += 3;
			break;
		case 2:
			pushertoggle0.isOn = true;
			pushertoggle1.isOn = true;
			savesc.protein += 7;
			break;
		case 3:
			pushertoggle0.isOn = true;
			pushertoggle1.isOn = true;
			pushertoggle2.isOn = true;
			savesc.protein += 12;
			break;
		case 4:
			pushertoggle0.isOn = true;
			pushertoggle1.isOn = true;
			pushertoggle2.isOn = true;
			pushertoggle3.isOn = true;
			savesc.protein += 18;
			break;
		}

		switch (savesc.takeallpr) {
		case 1:
			takealltoggle0.isOn = true;
			savesc.protein += 3;
			break;
		case 2:
			takealltoggle0.isOn = true;
			takealltoggle1.isOn = true;
			savesc.protein += 7;
			break;
		case 3:
			takealltoggle0.isOn = true;
			takealltoggle1.isOn = true;
			takealltoggle2.isOn = true;
			savesc.protein += 12;
			break;
		case 4:
			takealltoggle0.isOn = true;
			takealltoggle1.isOn = true;
			takealltoggle2.isOn = true;
			takealltoggle3.isOn = true;
			savesc.protein += 18;
			break;
		}

		if (savesc.movelvl1pr == 1) {
			movelevel1toggle.isOn = true;
			savesc.protein += 7;
		}

		if (savesc.movelvl2pr == 1) {
			movelevel2toggle.isOn = true;
			savesc.protein += 14;
		}



	}


	void Fakeupdate (){


	




		//Shield Toggle Control
		if (savesc.protein >= 1 && savesc.shieldpr >= 0) {
			shieldtoggle0.interactable = true;
		} else {
			shieldtoggle0.interactable = false;
		}
		if (savesc.protein >= 2 && savesc.shieldpr >= 1 && shieldtoggle0.isOn == true) {
			shieldtoggle1.interactable = true;
		} else {
			shieldtoggle1.interactable = false;
		}
		if (savesc.protein >= 3 && savesc.shieldpr >= 2 && shieldtoggle0.isOn ==true && shieldtoggle1.isOn ==true) {
		shieldtoggle2.interactable = true;
		}else {
			shieldtoggle2.interactable = false;
		}
		if (savesc.protein >= 4 && savesc.shieldpr >= 3 && shieldtoggle0.isOn ==true && shieldtoggle1.isOn ==true && shieldtoggle2.isOn ==true) {
		shieldtoggle3.interactable = true;
		}else {
			shieldtoggle3.interactable = false;
		}

		//Magnet Toggle Control
		if (savesc.protein >=2 && savesc.magnetpr >=0 && savesc.shieldpr >= 2 ){
			magnettoggle0.interactable = true;
		} else {
			magnettoggle0.interactable = false;
		}
		if (savesc.protein >=3 && savesc.magnetpr >=1 && savesc.shieldpr >= 2 && magnettoggle0.isOn==true){
			magnettoggle1.interactable = true;
		} else {
			magnettoggle1.interactable = false;
		}
		if (savesc.protein >=4 && savesc.magnetpr >=2 && savesc.shieldpr >= 2 && magnettoggle0.isOn==true && magnettoggle1.isOn==true){
			magnettoggle2.interactable = true;
		} else {
			magnettoggle2.interactable = false;
		}
		if (savesc.protein >=5 && savesc.magnetpr >=3 && savesc.shieldpr >= 2 && magnettoggle0.isOn==true && magnettoggle1.isOn==true && magnettoggle2.isOn==true){
			magnettoggle3.interactable = true;
		} else {
			magnettoggle3.interactable = false;
		}

	  // Squeze Toggle Control
		if (savesc.protein >=2 && savesc.squezepr >=0 && savesc.shieldpr >= 2 ){
			dmgRedux0.interactable = true;
		} else {
			dmgRedux0.interactable = false;
		}
		if (savesc.protein >=3 && savesc.squezepr >=1 && savesc.shieldpr >= 2 && dmgRedux0.isOn==true){
			dmgRedux1.interactable = true;
		} else {
			dmgRedux1.interactable = false;
		}
		if (savesc.protein >=4 && savesc.squezepr >=2 && savesc.shieldpr >= 2 && dmgRedux0.isOn==true && dmgRedux1.isOn==true){
			dmgRedux2.interactable = true;
		} else {
			dmgRedux2.interactable = false;
		}
		if (savesc.protein >=5 && savesc.squezepr >=3 && savesc.shieldpr >= 2 && dmgRedux0.isOn==true && dmgRedux1.isOn==true && dmgRedux2.isOn==true){
			dmgRedux3.interactable = true;
		} else {
			dmgRedux3.interactable = false;
		}

		// NO enemy Toggle Control

		if (savesc.protein >=2 && savesc.noenemypr >=0 && savesc.shieldpr >= 2 ){
			noenemytoggle0.interactable = true;
		} else {
			noenemytoggle0.interactable = false;
		}
		if (savesc.protein >=3 && savesc.noenemypr >=1 && savesc.shieldpr >= 2 && noenemytoggle0.isOn==true){
			noenemytoggle1.interactable = true;
		} else {
			noenemytoggle1.interactable = false;
		}
		if (savesc.protein >=4 && savesc.noenemypr >=2 && savesc.shieldpr >= 2 && noenemytoggle0.isOn==true && noenemytoggle1.isOn==true){
			noenemytoggle2.interactable = true;
		} else {
			noenemytoggle2.interactable = false;
		}
		if (savesc.protein >=5 && savesc.noenemypr >=3 && savesc.shieldpr >= 2 && noenemytoggle0.isOn==true && noenemytoggle1.isOn==true && noenemytoggle2.isOn==true){
			noenemytoggle3.interactable = true;
		} else {
			noenemytoggle3.interactable = false;
		}

		//Pusher Toggle Control

		if (savesc.protein >=3 && savesc.pusherpr >=0  && savesc.magnetpr >= 2){
			pushertoggle0.interactable = true;
		} else {
			pushertoggle0.interactable = false;
		}
		if (savesc.protein >=4 && savesc.pusherpr >=1  && savesc.magnetpr >= 2 &&  pushertoggle0.isOn==true){
			pushertoggle1.interactable = true;
		} else {
			pushertoggle1.interactable = false;
		}
		if (savesc.protein >=5 && savesc.pusherpr >=2 &&  savesc.magnetpr >= 2 && pushertoggle0.isOn==true && pushertoggle1.isOn==true){
			pushertoggle2.interactable = true;
		} else {
			pushertoggle2.interactable = false;
		}
		if (savesc.protein >=6 && savesc.pusherpr >=3  && savesc.magnetpr >= 2 && pushertoggle0.isOn==true && pushertoggle1.isOn==true && pushertoggle2.isOn==true){
			pushertoggle3.interactable = true;
		} else {
			pushertoggle3.interactable = false;
		}

		//Take All toggle Control

		if (savesc.protein >=3 && savesc.takeallpr >=0 && savesc.noenemypr >= 2 ){
			takealltoggle0.interactable = true;
		} else {
			takealltoggle0.interactable = false;
		}
		if (savesc.protein >=4 && savesc.takeallpr >=1 && savesc.noenemypr >= 2  && takealltoggle0.isOn==true){
			takealltoggle1.interactable = true;
		} else {
			takealltoggle1.interactable = false;
		}
		if (savesc.protein >=5 && savesc.takeallpr >=2 && savesc.noenemypr >= 2 && takealltoggle0.isOn==true && takealltoggle1.isOn==true){
			takealltoggle2.interactable = true;
		} else {
			takealltoggle2.interactable = false;
		}
		if (savesc.protein >=6 && savesc.takeallpr >=3 && savesc.noenemypr >= 2 &&  takealltoggle0.isOn==true && takealltoggle1.isOn==true && takealltoggle2.isOn==true){
			takealltoggle3.interactable = true;
		} else {
			takealltoggle3.interactable = false;
		}
	

		//MOVE LEVEL1 TOGGLE CONTROL 

		if (savesc.protein >= 7 && savesc.movelvl1pr == 0 && savesc.squezepr == 4 ) {
			movelevel1toggle.interactable = true;
		} else {
			movelevel1toggle.interactable = false;

		}

		//Move level2 toggle control

		if (savesc.protein >= 14 && savesc.movelvl2pr == 0 && savesc.pusherpr ==4 && savesc.movelvl1pr==1 && savesc.takeallpr == 4) {
			movelevel2toggle.interactable = true;
		} else {
			movelevel2toggle.interactable = false;

		}


		//info Button Controlls (setting info buttons avaiable here)
		if (noenemytoggle0.isOn == true || noenemytoggle0.interactable == true) {
			noEnemyButton.interactable = true;
		} else {
			noEnemyButton.interactable = false;
		}
		if (dmgRedux0.isOn == true || dmgRedux0.interactable == true) {
			dmgReduxButton.interactable = true;
		}else {
			dmgReduxButton.interactable = false;
		}
		if (magnettoggle0.isOn == true || magnettoggle0.interactable == true) {
			magnetButton.interactable = true;
		}else {
			magnetButton.interactable = false;
		}
		if (takealltoggle0.isOn == true || takealltoggle0.interactable == true) {
			takeAllButton.interactable = true;
		}else {
			takeAllButton.interactable = false;
		}
		if (movelevel1toggle.isOn == true || movelevel1toggle.interactable == true) {
			squezeButton.interactable = true;
		}else {
			squezeButton.interactable = false;
		}
		if (pushertoggle0.isOn == true || pushertoggle0.interactable == true) {
			pusherButton.interactable = true;
		}else {
			pusherButton.interactable = false;
		}
		if (movelevel2toggle.isOn==true || movelevel2toggle.interactable==true){
			dashButton.interactable=true;
		}else {
			dashButton.interactable=false;
		}





	}

	// Shield Toggle Control Start
	public void Shieldtoggleonclick0(){
		savesc.protein -= 1;
		savesc.shieldpr = 1;
		shieldtoggle0.enabled = false;
		Fakeupdate ();
	}
	public void Shieldtoggleonclick1(){
		savesc.protein -= 2;
		savesc.shieldpr = 2;
		shieldtoggle1.enabled = false;
		Fakeupdate ();
		}
	public void Shieldtoggleonclick2(){
		savesc.protein -= 3;
		savesc.shieldpr = 3;
		shieldtoggle2.enabled = false;
		Fakeupdate ();
		}
	public void Shieldtoggleonclick3(){
		savesc.protein -= 4;
		savesc.shieldpr = 4;
		shieldtoggle3.enabled = false;
		Fakeupdate ();
		}




	//Magnet Toggle Control
	public void Magnettogglecontrol0(){
		savesc.protein -= 2;
		savesc.magnetpr = 1;
		magnettoggle0.enabled = false;
		Fakeupdate ();
		}
	public void Magnettogglecontrol1(){
		savesc.protein -= 3;
		savesc.magnetpr = 2;
		magnettoggle1.enabled = false;
		Fakeupdate ();
	}
	public void Magnettogglecontrol2(){
		savesc.protein -= 4;
		savesc.magnetpr = 3;
		magnettoggle2.enabled = false;
		Fakeupdate ();
	}
	public void Magnettogglecontrol3(){
		savesc.protein -= 5;
		savesc.magnetpr = 4;
		magnettoggle3.enabled = false;
		Fakeupdate ();
	}



	//Squeze Toggle Control
	public void Squezetogglecontrol0(){
		savesc.protein -= 2;
		savesc.squezepr = 1;
		dmgRedux0.enabled = false;
		Fakeupdate ();
	}
	public void Squezetogglecontrol1(){
		savesc.protein -= 3;
		savesc.squezepr = 2;
		dmgRedux1.enabled = false;
		Fakeupdate ();
	}
	public void Squezetogglecontrol2(){
		savesc.protein -= 4;
		savesc.squezepr = 3;
		dmgRedux2.enabled = false;
		Fakeupdate ();
	}
	public void Squezetogglecontrol3(){
		savesc.protein -= 5;
		savesc.squezepr = 4;
		dmgRedux3.enabled = false;
		Fakeupdate ();
	}



	//No Enemy Toggle Control

	public void NoEnemyTogglecontrol0(){
		savesc.protein -= 2;
		savesc.noenemypr = 1;
		noenemytoggle0.enabled = false;
		Fakeupdate ();
	}
	public void NoEnemyTogglecontrol1(){
		savesc.protein -= 3;
		savesc.noenemypr = 2;
		noenemytoggle1.enabled = false;
		Fakeupdate ();
	}
	public void NoEnemyTogglecontrol2(){
		savesc.protein -= 4;
		savesc.noenemypr = 3;
		noenemytoggle2.enabled = false;
		Fakeupdate ();
	}
	public void NoEnemyTogglecontrol3(){
		savesc.protein -= 5;
		savesc.noenemypr = 4;
		noenemytoggle3.enabled = false;
		Fakeupdate ();
	}

	//Pusher Enemy toggle Control

	public void PusherTogglecontrol0(){
		savesc.protein -= 3;
		savesc.pusherpr = 1;
		pushertoggle0.enabled = false;
		Fakeupdate ();
	}
	public void PusherTogglecontrol1(){
		savesc.protein -= 4;
		savesc.pusherpr = 2;
		pushertoggle1.enabled = false;
		Fakeupdate ();
	}
	public void PusherTogglecontrol2(){
		savesc.protein -= 5;
		savesc.pusherpr = 3;
		pushertoggle2.enabled = false;
		Fakeupdate ();
	}
	public void PusherTogglecontrol3(){
		savesc.protein -= 6;
		savesc.pusherpr = 4;
		pushertoggle3.enabled = false;
		Fakeupdate ();
	}


	//Take all toggle control
	public void TakeAllTogglecontrol0(){
		savesc.protein -= 3;
		savesc.takeallpr = 1;
		takealltoggle0.enabled = false;
		Fakeupdate ();
	}
	public void TakeAllTogglecontrol1(){
		savesc.protein -= 4;
		savesc.takeallpr = 2;
		takealltoggle1.enabled = false;
		Fakeupdate ();
	}
	public void TakeAllTogglecontrol2(){
		savesc.protein -= 5;
		savesc.takeallpr = 3;
		takealltoggle2.enabled = false;
		Fakeupdate ();
	}
	public void TakeAllTogglecontrol3(){
		savesc.protein -= 6;
		savesc.takeallpr = 4;
		takealltoggle3.enabled = false;
		Fakeupdate ();
	
	}




	public void MoveLevel1togglecontrol()
	{
		savesc.protein -=  7; 
		savesc.movelvl1pr = 1;
		movelevel1toggle.enabled = false;
		Fakeupdate ();
	}


	public void MoveLevel2togglecontrol()
	{
		savesc.protein -=  14; 
		savesc.movelvl2pr = 1;
		movelevel2toggle.enabled = false;
		Fakeupdate ();
	}




}

