using System;
using UnityEngine;

namespace HadiHD.EasyCode
{
	public static class GOUtils
	{
		/// <summary>
		/// Gets the position.
		/// </summary>
		/// <returns>The position.</returns>
		/// <param name="o">O.</param>
		public static Vector3 GetPosition(this GameObject o)
		{
			return o.transform.position;
		}
		/// <summary>
		/// Sets the position.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="newPosition">New position.</param>
		public static void SetPosition(this GameObject o, Vector3 newPosition)
		{
			o.transform.position = newPosition;
		}
		/// <summary>
		/// Sets the position.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public static void SetPosition(this GameObject o, int x, int y, int z)
		{
			o.transform.position = new Vector3 (x, y, z);
		}
		/// <summary>
		/// Gets the local position.
		/// </summary>
		/// <returns>The local position.</returns>
		/// <param name="o">O.</param>
		public static Vector3 GetLocalPosition(this GameObject o)
		{
			return o.transform.localPosition;
		}
		/// <summary>
		/// Sets the local position.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="newPosition">New position.</param>
		public static void SetLocalPosition(this GameObject o, Vector3 newPosition)
		{
			o.transform.localPosition = newPosition;
		}
		/// <summary>
		/// Sets the local position.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public static void SetLocalPosition(this GameObject o, int x, int y, int z)
		{
			o.transform.localPosition = new Vector3 (x, y, z);
		}
		/// <summary>
		/// Gets the euler angles.
		/// </summary>
		/// <param name="o">O.</param>
		public static Vector3 GetEulerAngles(this GameObject o)
		{
			return o.transform.eulerAngles;
		}
		/// <summary>
		/// Sets the euler angles.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="newEulerAngles">New euler angles.</param>
		public static void SetEulerAngles(this GameObject o, Vector3 newEulerAngles)
		{
			o.transform.eulerAngles = newEulerAngles;
		}
		/// <summary>
		/// Gets the local euler angles.
		/// </summary>
		/// <returns>The local euler angles.</returns>
		/// <param name="o">O.</param>
		public static Vector3 GetLocalEulerAngles(this GameObject o)
		{
			return o.transform.localEulerAngles;
		}
		/// <summary>
		/// Sets the local euler angles.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="newLocalEulerAngles">New local euler angles.</param>
		public static void SetLocalEulerAngles(this GameObject o, Vector3 newLocalEulerAngles)
		{
			o.transform.localEulerAngles = newLocalEulerAngles;
		}
		/// <summary>
		/// Sets the local euler angles.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public static void SetLocalEulerAngles(this GameObject o, int x, int y, int z)
		{
			o.transform.localEulerAngles = new Vector3 (x, y, z);
		}

		/// <summary>
		/// Gets the parent.
		/// </summary>
		/// <returns>The parent.</returns>
		/// <param name="o">O.</param>
		public static GameObject GetParent(this GameObject o)
		{
			return o.transform.parent.gameObject;
		}

		/// <summary>
		/// Sets the parent.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="parent">Parent.</param>
		public static void SetParent(this GameObject o, GameObject parent)
		{
			o.transform.parent = parent.transform;
		}

		/// <summary>
		/// Delete gameobject.
		/// </summary>
		/// <param name="o">O.</param>
		public static void Delete(this GameObject o)
		{
			UnityEngine.Object.Destroy (o);
		}

		/// <summary>
		/// Clone gameobject.
		/// </summary>
		/// <param name="o">O.</param>
		public static GameObject Clone(this GameObject o, string name = null)
		{
			var x = UnityEngine.Object.Instantiate (o);
			if (name != null) x.name = name;
			return x;
		}

		/// <summary>
		/// Adds the child.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="obj">Object.</param>
		public static void AddChild(this GameObject o, GameObject obj)
		{
			obj.SetParent (o);
		}

		/// <summary>
		/// Determines if has child the specified o obj.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="obj">Object.</param>
		public static bool HasChild(this GameObject o, GameObject obj)
		{
			for (int i = 0; i < o.transform.childCount; i++)
				if (o.transform.GetChild(i).Equals(obj)) return true;
			return false;
		}
	}
	public class EzBehaviour : MonoBehaviour
	{
		/// <summary>
		/// Gets or sets the position.
		/// </summary>
		/// <value>The position.</value>
		public Vector3 position
		{
			get { return transform.position; }
			set { transform.position = value; }
		}
		/// <summary>
		/// Gets or sets the local position.
		/// </summary>
		/// <value>The local position.</value>
		public Vector3 localPosition
		{
			get { return transform.localPosition; }
			set { transform.localPosition = value; }
		}
		/// <summary>
		/// Gets or sets the rotation.
		/// </summary>
		/// <value>The rotation.</value>
		public Quaternion rotation
		{
			get { return transform.rotation; }
			set { transform.rotation = value; }
		}
		/// <summary>
		/// Gets or sets the local rotation.
		/// </summary>
		/// <value>The local rotation.</value>
		public Quaternion localRotation
		{
			get { return transform.localRotation; }
			set { transform.localRotation = value; }
		}

		/// <summary>
		/// Gets or sets the euler angles.
		/// </summary>
		/// <value>The euler angles.</value>
		public Vector3 eulerAngles
		{
			get { return transform.eulerAngles; }
			set { transform.eulerAngles = value; }
		}
		/// <summary>
		/// Gets or sets the local euler angles.
		/// </summary>
		/// <value>The euler angles.</value>
		public Vector3 localEulerAngles
		{
			get { return transform.localEulerAngles; }
			set { transform.localEulerAngles = value; }
		}

		/// <summary>
		/// Gets the forward.
		/// </summary>
		/// <value>The forward.</value>
		public Vector3 forward
		{
			get { return transform.forward; }
		}
		/// <summary>
		/// Gets the back.
		/// </summary>
		/// <value>The back.</value>
		public Vector3 back
		{
			get { return -transform.forward; }
		}
		/// <summary>
		/// Gets the left.
		/// </summary>
		/// <value>The left.</value>
		public Vector3 left
		{
			get { return -transform.right; }
		}
		/// <summary>
		/// Gets the right.
		/// </summary>
		/// <value>The right.</value>
		public Vector3 right
		{
			get { return transform.right; }
		}

		/// <summary>
		/// Gets or sets the parent.
		/// </summary>
		/// <value>The parent.</value>
		public GameObject parent
		{
			get { return transform.parent.gameObject; }
			set { transform.parent = value.transform; }
		}

		public Rigidbody rigidBody
		{
			get { return GetComponent<Rigidbody> (); }
		}
		public Rigidbody2D rigidBody2D
		{
			get { return GetComponent<Rigidbody2D> (); }
		}
		public CharacterController characterController
		{
			get { return GetComponent<CharacterController> (); }
		}
		public Collider collider
		{
			get { return GetComponent<Collider> (); }
		}
		public Collider[] colliders
		{
			get { return GetComponents<Collider> (); }
		}
		public Collider2D collider2D
		{
			get { return GetComponent<Collider2D> (); }
		}
		public Collider2D[] colliders2d
		{
			get { return GetComponents<Collider2D> (); }
		}
		public Animator animator
		{
			get { return GetComponent<Animator> (); }
		}
		public Animation animation
		{
			get { return GetComponent<Animation> (); }
		}
		public Camera camera
		{
			get { return GetComponent<Camera> (); }
		}
		public Light light
		{
			get { return GetComponent<Light> (); }
		}
		public ParticleSystem particle
		{
			get { return GetComponent<ParticleSystem> (); }
		}
		public AudioSource audio
		{
			get { return GetComponent<AudioSource> (); }
		}
		public Canvas canvas
		{
			get { return GetComponent<Canvas> (); }
		}
		public MeshRenderer meshRenderer
		{
			get { return GetComponent<MeshRenderer> (); }
		}
		public MeshFilter meshFilter
		{
			get { return GetComponent<MeshFilter> (); }
		}
		public RectTransform rectTransform
		{
			get { return GetComponent<RectTransform> (); }
		}
		public Component[] components
		{
			get { return GetComponents<Component> (); }
		}
		public LODGroup lodGroup
		{
			get { return GetComponent<LODGroup> (); }
		}

		/// <summary>
		/// Find the specified game object.
		/// </summary>
		/// <param name="goName">Go name.</param>
		public GameObject Find(string goName)
		{
			return GameObject.Find (goName);
		}
		/// <summary>
		/// Finds with tag.
		/// </summary>
		/// <returns>The tag.</returns>
		/// <param name="tag">Tag.</param>
		public GameObject FindTag(string tag)
		{
			return GameObject.FindWithTag (tag);
		}
		/// <summary>
		/// Creates the game object.
		/// </summary>
		/// <returns>The game object.</returns>
		/// <param name="goName">Go name.</param>
		/// <param name="components">Components.</param>
		public GameObject CreateGameObject(string goName, Type[] components = null)
		{
			return new GameObject (goName, components);
		}
	}

	/// <summary>
	/// Example.
	/// </summary>
	public class Example : EzBehaviour
	{
		public int weaponIndex;
		public GameObject[] weaponPrefabs;
		public GameObject playerPrefab;

		void Start()
		{
			GameObject player = playerPrefab.Clone ();
			GameObject weapon = weaponPrefabs [weaponIndex].Clone ();

			var weapons = CreateGameObject ("Weapons");
			weapons.SetParent (player.gameObject);
			weapons.AddChild (weapon);

			player.SetPosition (new Vector3 (0, 0, 0));
			gameObject.Clone ();
		}

		void Update()
		{

		}
	}
}
