using System;
using System.Collections.Generic;
using Endnight.Animation;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public class VailStateMachineEvents : SonsAnimStateEvents<VailStateMachineEvents.VailEvent>
	{
		// Token: 0x06000833 RID: 2099 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public List<VailStateMachineEvents.VailEvent> GetEventList()
		{
			return null;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2B66D20", Offset = "0x2B65320", VA = "0x182B66D20", Slot = "18")]
		protected override bool InitEventReceiver(Animator animator)
		{
			return default(bool);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2B66E70", Offset = "0x2B65470", VA = "0x182B66E70", Slot = "19")]
		protected override void SendRangeEvent(AnimStateEventBase ev, bool active, int stateNameHash)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2B67150", Offset = "0x2B65750", VA = "0x182B67150", Slot = "20")]
		protected override void SendSingleEvent(AnimStateEventBase ev)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2B67A60", Offset = "0x2B66060", VA = "0x182B67A60", Slot = "22")]
		protected override void CheckErrors(AnimatorStateInfo stateInfo)
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2B67C80", Offset = "0x2B66280", VA = "0x182B67C80")]
		public VailStateMachineEvents()
		{
		}

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		public const int MaxTypes = 50;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x30")]
		private VailAnimEvents _eventReceiver;

		// Token: 0x020000D7 RID: 215
		[Token(Token = "0x20000D7")]
		[Serializable]
		public class VailEvent : AnimStateEventBase
		{
			// Token: 0x06000839 RID: 2105 RVA: 0x00005B98 File Offset: 0x00003D98
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x2B67CC0", Offset = "0x2B662C0", VA = "0x182B67CC0", Slot = "7")]
			public virtual Color GetGuiColor()
			{
				return default(Color);
			}

			// Token: 0x0600083A RID: 2106 RVA: 0x00005BB0 File Offset: 0x00003DB0
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x2B67E60", Offset = "0x2B66460", VA = "0x182B67E60", Slot = "4")]
			public override bool IsRange()
			{
				return default(bool);
			}

			// Token: 0x0600083B RID: 2107 RVA: 0x00005BC8 File Offset: 0x00003DC8
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
			public override bool EndOnExitStart()
			{
				return default(bool);
			}

			// Token: 0x0600083C RID: 2108 RVA: 0x00005BE0 File Offset: 0x00003DE0
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x2B67E90", Offset = "0x2B66490", VA = "0x182B67E90")]
			public bool IsAudioEvent()
			{
				return default(bool);
			}

			// Token: 0x0600083D RID: 2109 RVA: 0x00005BF8 File Offset: 0x00003DF8
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x2B67EB0", Offset = "0x2B664B0", VA = "0x182B67EB0")]
			private bool ShowStringParam()
			{
				return default(bool);
			}

			// Token: 0x0600083E RID: 2110 RVA: 0x00005C10 File Offset: 0x00003E10
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x2B67EE0", Offset = "0x2B664E0", VA = "0x182B67EE0")]
			private bool ShowFloatParam()
			{
				return default(bool);
			}

			// Token: 0x0600083F RID: 2111 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x2B67F00", Offset = "0x2B66500", VA = "0x182B67F00")]
			private string StringParamName()
			{
				return null;
			}

			// Token: 0x06000840 RID: 2112 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x2B67FD0", Offset = "0x2B665D0", VA = "0x182B67FD0")]
			private string FloatParamName()
			{
				return null;
			}

			// Token: 0x06000841 RID: 2113 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x2B68040", Offset = "0x2B66640", VA = "0x182B68040", Slot = "6")]
			public override AnimStateEventBase Clone()
			{
				return null;
			}

			// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000842")]
			[Address(RVA = "0xAB20A0", Offset = "0xAB06A0", VA = "0x180AB20A0")]
			public VailEvent()
			{
			}

			// Token: 0x040006AB RID: 1707
			[Token(Token = "0x40006AB")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			internal VailAnimStateTag _type;

			// Token: 0x040006AC RID: 1708
			[Token(Token = "0x40006AC")]
			[FieldOffset(Offset = "0x30")]
			[EventRef]
			public string _audioEvent;

			// Token: 0x040006AD RID: 1709
			[Token(Token = "0x40006AD")]
			[FieldOffset(Offset = "0x38")]
			public string _stringParam;

			// Token: 0x040006AE RID: 1710
			[Token(Token = "0x40006AE")]
			[FieldOffset(Offset = "0x40")]
			public float _floatParam;
		}
	}
}
