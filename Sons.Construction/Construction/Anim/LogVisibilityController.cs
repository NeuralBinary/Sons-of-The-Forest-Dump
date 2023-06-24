using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	[AddComponentMenu("Sons/Construction/Anim/LogVisibilityController")]
	public class LogVisibilityController : MonoBehaviour, IPlaceActionBeganReceiver, IPlaceActionFinishedReceiver
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x2DFA000", Offset = "0x2DF8600", VA = "0x182DFA000")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0000C14C File Offset: 0x0000A34C
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x2DFA120", Offset = "0x2DF8720", VA = "0x182DFA120")]
		private bool CheckShouldForceLogVisibility(out bool logVisible, out bool stoneVisible)
		{
			return default(bool);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x2DFA330", Offset = "0x2DF8930", VA = "0x182DFA330", Slot = "4")]
		public void BeginPlaceAction()
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x2DFA340", Offset = "0x2DF8940", VA = "0x182DFA340", Slot = "5")]
		public void FinishedPlaceAction()
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x2DFA350", Offset = "0x2DF8950", VA = "0x182DFA350")]
		private void SetAdditionalLogVisibility(bool visible)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LogVisibilityController()
		{
		}

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _heldLogVisibilityOverride;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _stoneVisibilityOverride;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _additionalHeldLogVisibilityOverride;
	}
}
