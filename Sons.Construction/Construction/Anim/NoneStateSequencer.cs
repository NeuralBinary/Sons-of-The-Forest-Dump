using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Animation;

namespace Construction.Anim
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	public class NoneStateSequencer : IAnimationSequencer
	{
		// Token: 0x06001616 RID: 5654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public NoneStateSequencer(IPlayerBuildingModeAction buildAction)
		{
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x2E06050", Offset = "0x2E04650", VA = "0x182E06050", Slot = "4")]
		private IEnumerator StateSequencingRoutine()
		{
			return null;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x2E060E0", Offset = "0x2E046E0", VA = "0x182E060E0", Slot = "5")]
		private void BeginLiveUpdate()
		{
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		private void LiveUpdate()
		{
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		private void PostIkUpdate()
		{
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x2E06120", Offset = "0x2E04720", VA = "0x182E06120", Slot = "9")]
		private void ReachedTriggerTime()
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x2E06160", Offset = "0x2E04760", VA = "0x182E06160", Slot = "10")]
		private void ReachedBouncePartialExitTime()
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		public void Cancel(bool forceCancel)
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		private void Terminate()
		{
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		[Token(Token = "0x170004A1")]
		private bool WasTriggered
		{
			[Token(Token = "0x6001620")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x0000C404 File Offset: 0x0000A604
		[Token(Token = "0x170004A2")]
		private bool AnimEventsOnly
		{
			[Token(Token = "0x6001621")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170004A3")]
		private ILayerBehaviourActivator[] LayerActivators
		{
			[Token(Token = "0x6001622")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170004A4")]
		private ILayerBehaviourActivator[] LayerDisablers
		{
			[Token(Token = "0x6001623")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0000C41C File Offset: 0x0000A61C
		[Token(Token = "0x170004A5")]
		public bool IsLiveUpdating
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x2E061A0", Offset = "0x2E047A0", VA = "0x182E061A0", Slot = "17")]
		private void StopLiveUpdate()
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x2E061E0", Offset = "0x2E047E0", VA = "0x182E061E0", Slot = "18")]
		public void BeginPerfectFinishIk()
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "19")]
		private void SetTargetInfo(TargetInfo targetInfo)
		{
		}

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x10")]
		private bool _unEquipLeftHand;

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x18")]
		private readonly IPlayerBuildingModeAction _buildAction;
	}
}
