using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E8 RID: 744
[Token(Token = "0x20002E8")]
[Serializable]
public class DragRigidbody : MonoBehaviour
{
	// Token: 0x06001309 RID: 4873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x2C63D40", Offset = "0x2C62D40", VA = "0x182C63D40", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130A")]
	[Address(RVA = "0x2C63A70", Offset = "0x2C62A70", VA = "0x182C63A70")]
	private SpringJoint SetupSpringJoint(Vector3 point, Rigidbody connectedBody)
	{
		return null;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x2C63830", Offset = "0x2C62830", VA = "0x182C63830", Slot = "5")]
	public virtual Camera GetCamera()
	{
		return null;
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x2C638D0", Offset = "0x2C628D0", VA = "0x182C638D0")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x2C64520", Offset = "0x2C63520", VA = "0x182C64520")]
	public DragRigidbody()
	{
	}

	// Token: 0x040012F4 RID: 4852
	[Token(Token = "0x40012F4")]
	[FieldOffset(Offset = "0x20")]
	public float spring;

	// Token: 0x040012F5 RID: 4853
	[Token(Token = "0x40012F5")]
	[FieldOffset(Offset = "0x24")]
	public float damper;

	// Token: 0x040012F6 RID: 4854
	[Token(Token = "0x40012F6")]
	[FieldOffset(Offset = "0x28")]
	public float drag;

	// Token: 0x040012F7 RID: 4855
	[Token(Token = "0x40012F7")]
	[FieldOffset(Offset = "0x2C")]
	public float angularDrag;

	// Token: 0x040012F8 RID: 4856
	[Token(Token = "0x40012F8")]
	[FieldOffset(Offset = "0x30")]
	public float distance;

	// Token: 0x040012F9 RID: 4857
	[Token(Token = "0x40012F9")]
	[FieldOffset(Offset = "0x34")]
	public bool attachToCenterOfMass;

	// Token: 0x040012FA RID: 4858
	[Token(Token = "0x40012FA")]
	[FieldOffset(Offset = "0x38")]
	private DragRigidbody.JointInfo _dragJoint;

	// Token: 0x040012FB RID: 4859
	[Token(Token = "0x40012FB")]
	[FieldOffset(Offset = "0x40")]
	private List<DragRigidbody.JointInfo> _tiedJoints;

	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	private class JointInfo
	{
		// Token: 0x0600130E RID: 4878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x2C66EA0", Offset = "0x2C65EA0", VA = "0x182C66EA0")]
		public void DestroyJoint()
		{
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x2C66F50", Offset = "0x2C65F50", VA = "0x182C66F50")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001310")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public JointInfo()
		{
		}

		// Token: 0x040012FC RID: 4860
		[Token(Token = "0x40012FC")]
		[FieldOffset(Offset = "0x10")]
		public SpringJoint joint;

		// Token: 0x040012FD RID: 4861
		[Token(Token = "0x40012FD")]
		[FieldOffset(Offset = "0x18")]
		public float oldDrag;

		// Token: 0x040012FE RID: 4862
		[Token(Token = "0x40012FE")]
		[FieldOffset(Offset = "0x1C")]
		public float oldAngularDrag;

		// Token: 0x040012FF RID: 4863
		[Token(Token = "0x40012FF")]
		[FieldOffset(Offset = "0x20")]
		public float hitDistance;
	}
}
