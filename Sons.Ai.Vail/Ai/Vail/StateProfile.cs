using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	[Serializable]
	public class StateProfile
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2B33E40", Offset = "0x2B32440", VA = "0x182B33E40")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2B33ED0", Offset = "0x2B324D0", VA = "0x182B33ED0")]
		private StateProfile()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2B33F90", Offset = "0x2B32590", VA = "0x182B33F90")]
		internal StateProfile(State key)
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2B34000", Offset = "0x2B32600", VA = "0x182B34000")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x600061D")]
		[Address(RVA = "0xEEB890", Offset = "0xEE9E90", VA = "0x180EEB890")]
		public State GetState()
		{
			return default(State);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2B34090", Offset = "0x2B32690", VA = "0x182B34090")]
		public void SetState(State newKey)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
		public float GetVeryCloseDistance()
		{
			return 0f;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
		public float GetNearDistance()
		{
			return 0f;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
		public float GetFarDistance()
		{
			return 0f;
		}

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private State _stateKey;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _veryCloseDistance;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _nearDistance;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _farDistance;
	}
}
