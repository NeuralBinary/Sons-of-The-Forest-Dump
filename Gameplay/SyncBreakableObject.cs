using System;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006C7 RID: 1735
	[Token(Token = "0x20006C7")]
	[AddComponentMenu("Sons/Gameplay/SyncBreakableObject")]
	public class SyncBreakableObject : BoltEntityBehaviourWrapper<IBreakableObjectState>
	{
		// Token: 0x06002C73 RID: 11379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x2DFA840", Offset = "0x2DF9840", VA = "0x182DFA840")]
		private void Start()
		{
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x2DFA800", Offset = "0x2DF9800", VA = "0x182DFA800")]
		private void OnEnable()
		{
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x2DFA570", Offset = "0x2DF9570", VA = "0x182DFA570", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x2A0D0C0", Offset = "0x2A0C0C0", VA = "0x182A0D0C0")]
		private void BrokenChanged()
		{
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x2DFA700", Offset = "0x2DF9700", VA = "0x182DFA700")]
		public void Break()
		{
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C78")]
		[Address(RVA = "0x2DFA8E0", Offset = "0x2DF98E0", VA = "0x182DFA8E0")]
		public SyncBreakableObject()
		{
		}

		// Token: 0x040027CF RID: 10191
		[Token(Token = "0x40027CF")]
		[FieldOffset(Offset = "0x30")]
		public Action OnBrokenChanged;

		// Token: 0x040027D0 RID: 10192
		[Token(Token = "0x40027D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rigidBodyTransform;
	}
}
