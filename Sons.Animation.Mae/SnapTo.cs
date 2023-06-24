using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[Serializable]
	public class SnapTo : ActionTemplate
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2D1F860", Offset = "0x2D1DE60", VA = "0x182D1F860", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x265ED30", Offset = "0x265D330", VA = "0x18265ED30")]
		private void UseGameTime()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2D1F880", Offset = "0x2D1DE80", VA = "0x182D1F880")]
		private void UseStateTime()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2D1F890", Offset = "0x2D1DE90", VA = "0x182D1F890", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2D1F900", Offset = "0x2D1DF00", VA = "0x182D1F900", Slot = "9")]
		public override bool NoRootMotion()
		{
			return default(bool);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2D1F910", Offset = "0x2D1DF10", VA = "0x182D1F910", Slot = "12")]
		internal override bool Update()
		{
			return default(bool);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2D1FA40", Offset = "0x2D1E040", VA = "0x182D1FA40", Slot = "13")]
		internal override void DoEnd()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2D1FA90", Offset = "0x2D1E090", VA = "0x182D1FA90", Slot = "14")]
		internal override void DoInterrupted()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2D1FAE0", Offset = "0x2D1E0E0", VA = "0x182D1FAE0")]
		private void StateUpdate()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2D1FD30", Offset = "0x2D1E330", VA = "0x182D1FD30")]
		private void TimeUpdate()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2D1FE10", Offset = "0x2D1E410", VA = "0x182D1FE10")]
		private void StartSnapTo()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2D1F620", Offset = "0x2D1DC20", VA = "0x182D1F620", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2D1FF40", Offset = "0x2D1E540", VA = "0x182D1FF40")]
		private static float GetAnimatorStateNormalizedTime(Animator animator, int stateHashId)
		{
			return 0f;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2D20060", Offset = "0x2D1E660", VA = "0x182D20060")]
		public SnapTo()
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private bool _useStateTime;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WaitForState _stateTime;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector2 _stateTimePercent;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _timeStartOffset;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _timeLengthOffset;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x0")]
		private static Color _stateTimeColor;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x10")]
		private static Color _gameTimeColor;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		private const string GameTimeString = "Game Time";

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		private const string StateTimeString = "State Time";

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SnapTo.SnapToType _motionType;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _stopDistance;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _snapRotation;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		private bool _snapVertical;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x8A")]
		[SerializeField]
		private bool _checkReserveLocation;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x8B")]
		private bool _hasStarted;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x8C")]
		private bool _finishedSnap;

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public enum SnapToType
		{
			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			Linear,
			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			JumpArc
		}
	}
}
