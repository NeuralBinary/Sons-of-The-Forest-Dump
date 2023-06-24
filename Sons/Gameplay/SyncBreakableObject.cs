using System;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007FF RID: 2047
	[Token(Token = "0x20007FF")]
	[AddComponentMenu("Sons/Gameplay/SyncBreakableObject")]
	public class SyncBreakableObject : BoltEntityBehaviourWrapper<IBreakableObjectState>
	{
		// Token: 0x06003742 RID: 14146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x353BCB0", Offset = "0x353A2B0", VA = "0x18353BCB0")]
		private void Start()
		{
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x353BD50", Offset = "0x353A350", VA = "0x18353BD50")]
		private void OnEnable()
		{
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x353BD90", Offset = "0x353A390", VA = "0x18353BD90", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x2FF7330", Offset = "0x2FF5930", VA = "0x182FF7330")]
		private void BrokenChanged()
		{
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x353BEF0", Offset = "0x353A4F0", VA = "0x18353BEF0")]
		public void Break()
		{
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x353C050", Offset = "0x353A650", VA = "0x18353C050")]
		public SyncBreakableObject()
		{
		}

		// Token: 0x04002FB9 RID: 12217
		[Token(Token = "0x4002FB9")]
		[FieldOffset(Offset = "0x30")]
		public Action OnBrokenChanged;

		// Token: 0x04002FBA RID: 12218
		[Token(Token = "0x4002FBA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rigidBodyTransform;
	}
}
