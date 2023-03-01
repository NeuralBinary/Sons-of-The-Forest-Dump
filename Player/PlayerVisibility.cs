using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	[AddComponentMenu("Sons/Player/Player Visibility")]
	public class PlayerVisibility : MonoBehaviour
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x17000623")]
		public bool IsCrouching
		{
			[Token(Token = "0x600310B")]
			[Address(RVA = "0x22A6850", Offset = "0x22A5850", VA = "0x1822A6850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x17000624")]
		public bool IsRunning
		{
			[Token(Token = "0x600310C")]
			[Address(RVA = "0x6743C0", Offset = "0x6733C0", VA = "0x1806743C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x17000625")]
		public float VisibleRangeMultiplier
		{
			[Token(Token = "0x600310D")]
			[Address(RVA = "0x6C5560", Offset = "0x6C4560", VA = "0x1806C5560")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600310E")]
		[Address(RVA = "0x2E54A40", Offset = "0x2E53A40", VA = "0x182E54A40")]
		private void Update()
		{
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600310F")]
		[Address(RVA = "0x2E541D0", Offset = "0x2E531D0", VA = "0x182E541D0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x6003110")]
		[Address(RVA = "0x2E545D0", Offset = "0x2E535D0", VA = "0x182E545D0")]
		private float GetTreeOcclusion()
		{
			return default(float);
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x2E54910", Offset = "0x2E53910", VA = "0x182E54910")]
		private void LerpToGoal(float goal, ref float result)
		{
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x2E54670", Offset = "0x2E53670", VA = "0x182E54670")]
		private float GetVisibilityMult()
		{
			return default(float);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x6003113")]
		[Address(RVA = "0x2E53A40", Offset = "0x2E52A40", VA = "0x182E53A40")]
		private float ComputeVisibilityMult(bool crouching, bool running, float camoRating, float illumination, float treeOcclusion, float bushCover)
		{
			return default(float);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003114")]
		[Address(RVA = "0x2E54A40", Offset = "0x2E53A40", VA = "0x182E54A40")]
		private void UpdatePlayerStimuliVisibility()
		{
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003115")]
		[Address(RVA = "0x2E53900", Offset = "0x2E52900", VA = "0x182E53900")]
		public void AddCover(DynamicBoneTrigger tr)
		{
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003116")]
		[Address(RVA = "0x2E549E0", Offset = "0x2E539E0", VA = "0x182E549E0")]
		public void RemoveCover(DynamicBoneTrigger tr)
		{
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003117")]
		[Address(RVA = "0x2E539E0", Offset = "0x2E529E0", VA = "0x182E539E0")]
		public void ClearCover()
		{
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0000E088 File Offset: 0x0000C288
		[Token(Token = "0x6003118")]
		[Address(RVA = "0x2E54410", Offset = "0x2E53410", VA = "0x182E54410")]
		private float GetBushCover()
		{
			return default(float);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003119")]
		[Address(RVA = "0x2E53AF0", Offset = "0x2E52AF0", VA = "0x182E53AF0")]
		public void DrawDebugOverlay()
		{
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311A")]
		[Address(RVA = "0x2E54A90", Offset = "0x2E53A90", VA = "0x182E54A90")]
		public PlayerVisibility()
		{
		}

		// Token: 0x04002AD0 RID: 10960
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public PlayerStimuli _playerStimuli;

		// Token: 0x04002AD1 RID: 10961
		[Token(Token = "0x4002AD1")]
		[FieldOffset(Offset = "0x28")]
		private float _goalSpeedUp;

		// Token: 0x04002AD2 RID: 10962
		[Token(Token = "0x4002AD2")]
		[FieldOffset(Offset = "0x2C")]
		private float _goalSpeedDown;

		// Token: 0x04002AD3 RID: 10963
		[Token(Token = "0x4002AD3")]
		[FieldOffset(Offset = "0x30")]
		private float _minVisionRangeMult;

		// Token: 0x04002AD4 RID: 10964
		[Token(Token = "0x4002AD4")]
		[FieldOffset(Offset = "0x34")]
		private float _stealthFactorMultiplier;

		// Token: 0x04002AD5 RID: 10965
		[Token(Token = "0x4002AD5")]
		[FieldOffset(Offset = "0x38")]
		private float _bushCoverMax;

		// Token: 0x04002AD6 RID: 10966
		[Token(Token = "0x4002AD6")]
		[FieldOffset(Offset = "0x3C")]
		private bool _invisible;

		// Token: 0x04002AD7 RID: 10967
		[Token(Token = "0x4002AD7")]
		[FieldOffset(Offset = "0x40")]
		private float _visibleRangeMultiplier;

		// Token: 0x04002AD8 RID: 10968
		[Token(Token = "0x4002AD8")]
		[FieldOffset(Offset = "0x48")]
		private List<DynamicBoneTrigger> _coverBushes;

		// Token: 0x04002AD9 RID: 10969
		[Token(Token = "0x4002AD9")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _prevPlayerPos;

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _prevPrevPlayerPos;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x68")]
		private float _currentVisibilityGoal;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x6C")]
		private int _lastVisibilityResultFrame;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x70")]
		private float _lastVisibilityResult;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x74")]
		private bool _isCrouching;

		// Token: 0x04002ADF RID: 10975
		[Token(Token = "0x4002ADF")]
		[FieldOffset(Offset = "0x75")]
		private bool _isRunning;
	}
}
