using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	[AddComponentMenu("Sons/Ai/Player Aura")]
	public class PlayerAura : MonoBehaviour
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2B298F0", Offset = "0x2B27EF0", VA = "0x182B298F0")]
		public void Update()
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerAura()
		{
		}

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x20")]
		private bool _wasInVillage;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _inVillageAura;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _notInVillageAura;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x38")]
		private float _lastCheckTime;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x3C")]
		private bool _initialized;
	}
}
