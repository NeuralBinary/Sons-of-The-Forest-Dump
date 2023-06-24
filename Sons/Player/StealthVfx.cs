using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Player
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	public class StealthVfx : MonoBehaviour
	{
		// Token: 0x06002A90 RID: 10896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x33FE270", Offset = "0x33FC870", VA = "0x1833FE270")]
		private void Start()
		{
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x33FE330", Offset = "0x33FC930", VA = "0x1833FE330")]
		private void Update()
		{
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x33FE4E0", Offset = "0x33FCAE0", VA = "0x1833FE4E0")]
		private float ConvertToGoal()
		{
			return 0f;
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x33FE520", Offset = "0x33FCB20", VA = "0x1833FE520")]
		private float GetStealthFactor()
		{
			return 0f;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x33FE580", Offset = "0x33FCB80", VA = "0x1833FE580")]
		public StealthVfx()
		{
		}

		// Token: 0x040025B1 RID: 9649
		[Token(Token = "0x40025B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _fadeVolume;

		// Token: 0x040025B2 RID: 9650
		[Token(Token = "0x40025B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _smoothTime;

		// Token: 0x040025B3 RID: 9651
		[Token(Token = "0x40025B3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _smoothMaxSpeed;

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _remapMin;

		// Token: 0x040025B5 RID: 9653
		[Token(Token = "0x40025B5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _remapMax;

		// Token: 0x040025B6 RID: 9654
		[Token(Token = "0x40025B6")]
		[FieldOffset(Offset = "0x38")]
		private float _currentStealthFactor;

		// Token: 0x040025B7 RID: 9655
		[Token(Token = "0x40025B7")]
		[FieldOffset(Offset = "0x40")]
		private PlayerVisibility _playerVisibility;

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x48")]
		private float _currentGoal;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0x4C")]
		private float _smoothDampVel;

		// Token: 0x040025BA RID: 9658
		[Token(Token = "0x40025BA")]
		[FieldOffset(Offset = "0x50")]
		private float _currentValue;

		// Token: 0x040025BB RID: 9659
		[Token(Token = "0x40025BB")]
		[FieldOffset(Offset = "0x54")]
		private bool _hasApplied;
	}
}
