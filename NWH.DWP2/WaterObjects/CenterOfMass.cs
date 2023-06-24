using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Rigidbody))]
	public class CenterOfMass : MonoBehaviour
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x26FCBE0", Offset = "0x26FB1E0", VA = "0x1826FCBE0")]
		private void Start()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x26FCD20", Offset = "0x26FB320", VA = "0x1826FCD20")]
		private void Update()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x26FCE70", Offset = "0x26FB470", VA = "0x1826FCE70")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x26FD250", Offset = "0x26FB850", VA = "0x1826FD250")]
		public CenterOfMass()
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 centerOfMassOffset;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x2C")]
		public bool showCOM;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 centerOfMass;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 prevOffset;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x48")]
		private Rigidbody rb;
	}
}
