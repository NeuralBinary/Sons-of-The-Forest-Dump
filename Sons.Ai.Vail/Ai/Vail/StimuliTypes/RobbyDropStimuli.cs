using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	[AddComponentMenu("Sons/Stimuli/Robby Drop Stimuli")]
	public class RobbyDropStimuli : RobbyOrderStimuliBase
	{
		// Token: 0x06000DF3 RID: 3571 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x2BA8C30", Offset = "0x2BA7230", VA = "0x182BA8C30")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x2BA8C60", Offset = "0x2BA7260", VA = "0x182BA8C60")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x2BA8CE0", Offset = "0x2BA72E0", VA = "0x182BA8CE0")]
		public float GetMoveStopDistance()
		{
			return 0f;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x2B47450", Offset = "0x2B45A50", VA = "0x182B47450")]
		public void SetStopMoveDistance(float value)
		{
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x2BA8CF0", Offset = "0x2BA72F0", VA = "0x182BA8CF0", Slot = "8")]
		protected override void Awake()
		{
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x2BA8D50", Offset = "0x2BA7350", VA = "0x182BA8D50", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x2BA8ED0", Offset = "0x2BA74D0", VA = "0x182BA8ED0")]
		public void SetAsDropTargetForType(string vailItemType)
		{
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x2BA9010", Offset = "0x2BA7610", VA = "0x182BA9010")]
		public void SetHolderDropTarget(MonoBehaviour target)
		{
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x2BA9080", Offset = "0x2BA7680", VA = "0x182BA9080", Slot = "16")]
		public override int OnDropEvent(VailActor actor)
		{
			return 0;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x2BA9370", Offset = "0x2BA7970", VA = "0x182BA9370")]
		public void SetPositionToDropTarget()
		{
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x2BA9560", Offset = "0x2BA7B60", VA = "0x182BA9560")]
		public RobbyDropStimuli()
		{
		}

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected MonoBehaviour _dropTarget;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0xB8")]
		private float _stopMoveDistance;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0xBC")]
		private bool _targetIsHolder;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		[FieldOffset(Offset = "0xC0")]
		private MonoBehaviour _originalDropTarget;
	}
}
