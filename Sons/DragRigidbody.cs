using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DC RID: 732
[Token(Token = "0x20002DC")]
[Serializable]
public class DragRigidbody : MonoBehaviour
{
	// Token: 0x0600133F RID: 4927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133F")]
	[Address(RVA = "0x31F0C70", Offset = "0x31EF270", VA = "0x1831F0C70", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001340")]
	[Address(RVA = "0x31F17D0", Offset = "0x31EFDD0", VA = "0x1831F17D0")]
	private SpringJoint SetupSpringJoint(Vector3 point, Rigidbody connectedBody)
	{
		return null;
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x31F1E60", Offset = "0x31F0460", VA = "0x1831F1E60", Slot = "5")]
	public virtual Camera GetCamera()
	{
		return null;
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x31F1F90", Offset = "0x31F0590", VA = "0x1831F1F90")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001343")]
	[Address(RVA = "0x31F2370", Offset = "0x31F0970", VA = "0x1831F2370")]
	public DragRigidbody()
	{
	}

	// Token: 0x0400131C RID: 4892
	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0x20")]
	public float spring;

	// Token: 0x0400131D RID: 4893
	[Token(Token = "0x400131D")]
	[FieldOffset(Offset = "0x24")]
	public float damper;

	// Token: 0x0400131E RID: 4894
	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0x28")]
	public float drag;

	// Token: 0x0400131F RID: 4895
	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0x2C")]
	public float angularDrag;

	// Token: 0x04001320 RID: 4896
	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0x30")]
	public float distance;

	// Token: 0x04001321 RID: 4897
	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0x34")]
	public bool attachToCenterOfMass;

	// Token: 0x04001322 RID: 4898
	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0x38")]
	private DragRigidbody.JointInfo _dragJoint;

	// Token: 0x04001323 RID: 4899
	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x40")]
	private List<DragRigidbody.JointInfo> _tiedJoints;

	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	private class JointInfo
	{
		// Token: 0x06001344 RID: 4932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x31F24F0", Offset = "0x31F0AF0", VA = "0x1831F24F0")]
		public void DestroyJoint()
		{
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x31F2700", Offset = "0x31F0D00", VA = "0x1831F2700")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JointInfo()
		{
		}

		// Token: 0x04001324 RID: 4900
		[Token(Token = "0x4001324")]
		[FieldOffset(Offset = "0x10")]
		public SpringJoint joint;

		// Token: 0x04001325 RID: 4901
		[Token(Token = "0x4001325")]
		[FieldOffset(Offset = "0x18")]
		public float oldDrag;

		// Token: 0x04001326 RID: 4902
		[Token(Token = "0x4001326")]
		[FieldOffset(Offset = "0x1C")]
		public float oldAngularDrag;

		// Token: 0x04001327 RID: 4903
		[Token(Token = "0x4001327")]
		[FieldOffset(Offset = "0x20")]
		public float hitDistance;
	}
}
