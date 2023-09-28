using UnityEngine;
using System.Collections;


public class ScriptOne : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}


public class VariablesAndFunctions : MonoBehaviour
{   
    int myInt = 5;
    
    
    void Start ()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }
    
    
    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}

public class BasicSyntax : MonoBehaviour
{
    void Start ()
    {
        //this line is there to tell me the x position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);
        
        if(transform.position.y <= 5f)
        {
            Debug.Log ("I'm about to hit the ground!");
        }
    }
}

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    
    
    void TemperatureTest ()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;
    
    
    void Start ()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}

public class DoWhileLoop : MonoBehaviour 
{
    void Start()
    {
        bool shouldContinue = false;
        
        do
        {
            print ("Hello World");
            
        }while(shouldContinue == true);
    }
}

public class ForeachLoop : MonoBehaviour 
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5;
    
    
    private int beta = 0;
    private int gamma = 5;
    
    
    private AnotherClass myOtherClass;
    
    
    void Start ()
    {
        alpha = 29;
        
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    
    
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    
    
    void Update ()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}

public class AnotherClass
{
    public int apples;
    public int bananas;
    
    
    private int stapler;
    private int sellotape;
    
    
    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }
    
    
    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}

public class AwakeAndStart : MonoBehaviour
{
    void Awake ()
    {
        Debug.Log("Awake called.");
    }
    
    
    void Start ()
    {
        Debug.Log("Start called.");
    }
}

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    
    
    void Update ()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}

public class EnableComponents : MonoBehaviour
{
    private Light myLight;
    
    
    void Start ()
    {
        myLight = GetComponent<Light>();
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}

public class ActiveObjects : MonoBehaviour
{
    void Start ()
    {
        gameObject.SetActive(false);
    }
}

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    
    
    void Start ()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}

public class TransformFunctions : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}

using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}

// In this case, result = 4
float result = Mathf.Lerp (3f, 5f, 0.5f);

Vector3 from = new Vector3 (1f, 2f, 3f);
Vector3 to = new Vector3 (5f, 6f, 7f);

// Here result = (4, 5, 6)
Vector3 result = Vector3.Lerp (from, to, 0.75f);

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
}

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
}

public class DestroyBasic : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}

public class DestroyOther : MonoBehaviour
{
    public GameObject other;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}

public class DestroyComponent : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    void Start()
    {
        graphic.sprite = standard;    
    }

    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}

public class ButtonInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    void Start()
    {
        graphic.sprite = standard;    
    }

    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;
    
    
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;
        
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
}

public class AxisRawExample : MonoBehaviour
{
    public float range;
    public Text textOutput;
    
    
    void Update () 
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;
        
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
}

public class DualAxisExample : MonoBehaviour 
{
    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;
    
    void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        
        transform.position = new Vector3(xPos, 0, vPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");
    }
}

public class MouseClick : MonoBehaviour
{

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown ()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
}

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    
    
    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    
    
    void Awake ()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}

using UnityEngine;
using System.Collections;

public class AnotherScript : MonoBehaviour
{
    public int playerScore = 9001;
}

public class YetAnotherScript : MonoBehaviour
{
    public int numberOfPlayerDeaths = 3;
}

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f; 
    public float countdown = 3.0f;

    
    void Update ()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0.0f)
            light.enabled = true;
        
         if(Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }   
}

public class DatatypeScript : MonoBehaviour 
{
    void Start () 
    {
        //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);
        
        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }
    
    
    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    
    
    void Update ()
    {
        Movement();
        Shoot();
    }
    
    
    void Movement ()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
    
    
    void Shoot ()
    {
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
}

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;
        
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
        
        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }
        
        // Constructor
        public Stuff ()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }
    

    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);
    
    public Stuff myOtherStuff = new Stuff(50, 1.5f);
    
    void Start()
    {
        Debug.Log(myStuff.bullets); 
    }
}

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    
    
    void Update ()
    {
        Movement();
    }
    
    
    void Movement ()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    
    
    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}

public class RocketDestruction : MonoBehaviour
{
    void Start()
    {
        Destroy (gameObject, 1.5f);
    }
}

public class Arrays : MonoBehaviour
{
    public GameObject[] players;

    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        
        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number "+i+" is named "+players[i].name);
        }
    }
}

public class InvokeScript : MonoBehaviour 
{
    public GameObject target;
    
    
    void Start()
    {
        Invoke ("SpawnObject", 2);
    }
    
    void SpawnObject()
    {
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}

public class InvokeRepeating : MonoBehaviour 
{
    public GameObject target;
    
    
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }
    
    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }
}