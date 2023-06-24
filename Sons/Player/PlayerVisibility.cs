using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000661")]
	[AddComponentMenu("Sons/Player/Player Visibility")]
	public class PlayerVisibility : MonoBehaviour
	{
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x1700058E")]
		public bool IsCrouching
		{
			[Token(Token = "0x6002A80")]
			[Address(RVA = "0x270DEE0", Offset = "0x270C4E0", VA = "0x18270DEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[Token(Token = "0x1700058F")]
		public bool IsRunning
		{
			[Token(Token = "0x6002A81")]
			[Address(RVA = "0x7283F0", Offset = "0x7269F0", VA = "0x1807283F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x17000590")]
		public float VisibleRangeMultiplier
		{
			[Token(Token = "0x6002A82")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x33FCAF0", Offset = "0x33FB0F0", VA = "0x1833FCAF0")]
		private void Update()
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x33FCBE0", Offset = "0x33FB1E0", VA = "0x1833FCBE0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[Token(Token = "0x6002A85")]
		[Address(RVA = "0x33FCE00", Offset = "0x33FB400", VA = "0x1833FCE00")]
		private float GetTreeOcclusion()
		{
			return 0f;
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x33FCEA0", Offset = "0x33FB4A0", VA = "0x1833FCEA0")]
		private void LerpToGoal(float goal, ref float result)
		{
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x0000C900 File Offset: 0x0000AB00
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x33FCF90", Offset = "0x33FB590", VA = "0x1833FCF90")]
		private float GetVisibilityMult()
		{
			return 0f;
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x33FD2F0", Offset = "0x33FB8F0", VA = "0x1833FD2F0")]
		private float ComputeVisibilityMult(bool crouching, bool running, float camoRating, float illumination, float treeOcclusion, float bushCover)
		{
			return 0f;
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x33FCAF0", Offset = "0x33FB0F0", VA = "0x1833FCAF0")]
		private void UpdatePlayerStimuliVisibility()
		{
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x33FD3A0", Offset = "0x33FB9A0", VA = "0x1833FD3A0")]
		public void AddCover(DynamicBoneTrigger tr)
		{
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x33FD4A0", Offset = "0x33FBAA0", VA = "0x1833FD4A0")]
		public void RemoveCover(DynamicBoneTrigger tr)
		{
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x33FD500", Offset = "0x33FBB00", VA = "0x1833FD500")]
		public void ClearCover()
		{
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x33FD560", Offset = "0x33FBB60", VA = "0x1833FD560")]
		private float GetBushCover()
		{
			return 0f;
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x33FD850", Offset = "0x33FBE50", VA = "0x1833FD850")]
		public void DrawDebugOverlay()
		{
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x33FE0F0", Offset = "0x33FC6F0", VA = "0x1833FE0F0")]
		public PlayerVisibility()
		{
		}

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public PlayerStimuli _playerStimuli;

		// Token: 0x040025A2 RID: 9634
		[Token(Token = "0x40025A2")]
		[FieldOffset(Offset = "0x28")]
		private float _goalSpeedUp;

		// Token: 0x040025A3 RID: 9635
		[Token(Token = "0x40025A3")]
		[FieldOffset(Offset = "0x2C")]
		private float _goalSpeedDown;

		// Token: 0x040025A4 RID: 9636
		[Token(Token = "0x40025A4")]
		[FieldOffset(Offset = "0x30")]
		private float _minVisionRangeMult;

		// Token: 0x040025A5 RID: 9637
		[Token(Token = "0x40025A5")]
		[FieldOffset(Offset = "0x34")]
		private float _stealthFactorMultiplier;

		// Token: 0x040025A6 RID: 9638
		[Token(Token = "0x40025A6")]
		[FieldOffset(Offset = "0x38")]
		private float _bushCoverMax;

		// Token: 0x040025A7 RID: 9639
		[Token(Token = "0x40025A7")]
		[FieldOffset(Offset = "0x3C")]
		private bool _invisible;

		// Token: 0x040025A8 RID: 9640
		[Token(Token = "0x40025A8")]
		[FieldOffset(Offset = "0x40")]
		private float _visibleRangeMultiplier;

		// Token: 0x040025A9 RID: 9641
		[Token(Token = "0x40025A9")]
		[FieldOffset(Offset = "0x48")]
		private List<DynamicBoneTrigger> _coverBushes;

		// Token: 0x040025AA RID: 9642
		[Token(Token = "0x40025AA")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _prevPlayerPos;

		// Token: 0x040025AB RID: 9643
		[Token(Token = "0x40025AB")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _prevPrevPlayerPos;

		// Token: 0x040025AC RID: 9644
		[Token(Token = "0x40025AC")]
		[FieldOffset(Offset = "0x68")]
		private float _currentVisibilityGoal;

		// Token: 0x040025AD RID: 9645
		[Token(Token = "0x40025AD")]
		[FieldOffset(Offset = "0x6C")]
		private int _lastVisibilityResultFrame;

		// Token: 0x040025AE RID: 9646
		[Token(Token = "0x40025AE")]
		[FieldOffset(Offset = "0x70")]
		private float _lastVisibilityResult;

		// Token: 0x040025AF RID: 9647
		[Token(Token = "0x40025AF")]
		[FieldOffset(Offset = "0x74")]
		private bool _isCrouching;

		// Token: 0x040025B0 RID: 9648
		[Token(Token = "0x40025B0")]
		[FieldOffset(Offset = "0x75")]
		private bool _isRunning;
	}
}
