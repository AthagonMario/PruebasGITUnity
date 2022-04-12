using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using MachineDict = System.Collections.Generic.Dictionary< VoidFuncVoid, System.Collections.Generic.Dictionary< string, VoidFuncVoid > > ;
using MessageDict = System.Collections.Generic.Dictionary<string, VoidFuncVoid> ;

delegate void VoidFuncVoid ( );

public class EjemploEstadosSemaforo : MonoBehaviour
{ 
    VoidFuncVoid currentState ;
    MachineDict machine ;
    MessageDict messages ;

    float lastTime = 0.0f ;

    void InitMachine ( ) {
        machine = new MachineDict ( ) { 
            { Red,    new MessageDict ()  {  { "next" , Yellow   }  }  } , 
            { Yellow, new MessageDict ()  {  { "next" , Green    } , { "back", Red }  }  } , 
            { Green,  new MessageDict ()  {  { "back" , Yellow   }  }  } 
        }; // Machine ;
    }

    void _SendMessage ( string msg ) {
        currentState = messages [ msg ] ;
        messages = machine [ currentState ] ;
    }

    void Red( ) {
        print("RED") ;
        if ( lastTime + 2 < Time.time )  {
            lastTime = Time.time  ;
            _SendMessage("next")  ;
        }
    }

    bool ida ;
    void Yellow( ) { 
        print("Yellow") ;
        if ( lastTime + 2 < Time.time ) { 
            lastTime = Time.time ; 
            if ( ida ) _SendMessage("next") ;  else _SendMessage("back") ; 
            ida = !ida;
        }
    }
  
    void Green( ) {
        print("Green") ;
        if (lastTime + 1 < Time.time) {
            lastTime = Time.time ;
            _SendMessage("back") ;
        }
    }

    private void Start( ) {

        InitMachine ( ) ;
        currentState = Red ;
        messages = machine [ currentState ] ;

        lastTime = Time.time ;
    }

    private void Update( ) {
        currentState( ) ;
    }
}
