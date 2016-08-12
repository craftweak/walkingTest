using UnityEngine;

public class Scroller : MonoBehaviour
{
	[SerializeField] float _speed =1;
	public float speed{
		get { return _speed; }
		set { _speed = value; }
	}
	[SerializeField] float _wrapPoint =10;
	public float wrapPoint{
		get { return _wrapPoint; }
		set { _wrapPoint = value; }
	}

    float _position;

    void Start()
    {
        _position = Vector3.Dot(transform.position, transform.forward);
    }

    void Update()
    {
        _position += Time.deltaTime * _speed;

        if (_position > _wrapPoint) _position -= _wrapPoint * 2;

        transform.position = transform.forward * _position;
    }
}
