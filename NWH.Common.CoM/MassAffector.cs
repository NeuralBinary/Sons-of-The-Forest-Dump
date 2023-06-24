using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.CoM
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class MassAffector : MonoBehaviour, IMassAffector
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x26E8660", Offset = "0x26E6C60", VA = "0x1826E8660", Slot = "4")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820", Slot = "5")]
		public float GetMass()
		{
			return 0f;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "6")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MassAffector()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public float mass;
	}
}
