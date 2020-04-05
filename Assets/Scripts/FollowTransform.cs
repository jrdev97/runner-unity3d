using UnityEngine;

public class FollowTransform : MonoBehaviour
{
	public Transform transformObject;
	public int axis;

	[SerializeField]
	public AxisValue fixedAxis = null;

	private void Update()
	{
		Vector3 newPosition;

		newPosition = transform.position;

		if (this.fixedAxis != null || this.fixedAxis?.axis == axis)
			newPosition[this.fixedAxis.axis] = this.fixedAxis.value;
		else
			newPosition[axis] = transformObject.position[axis];

		transform.position = newPosition;
	}
}

[System.Serializable]
public class AxisValue
{
	public int axis;
	public float value;
}