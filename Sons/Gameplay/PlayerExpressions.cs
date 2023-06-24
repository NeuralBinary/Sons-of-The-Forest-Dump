using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation.BlendShapes;
using Sons.Wearable.Race;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	[AddComponentMenu("Sons/Gameplay/PlayerExpressions")]
	public class PlayerExpressions : MonoBehaviour
	{
		// Token: 0x06003549 RID: 13641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x34DD1E0", Offset = "0x34DB7E0", VA = "0x1834DD1E0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x34DD420", Offset = "0x34DBA20", VA = "0x1834DD420")]
		private void OnEnable()
		{
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x34DD540", Offset = "0x34DBB40", VA = "0x1834DD540")]
		private void OnDisable()
		{
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x34DD660", Offset = "0x34DBC60", VA = "0x1834DD660")]
		private void OnRaceChanged(PlayerRace.Race race)
		{
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x34DD8E0", Offset = "0x34DBEE0", VA = "0x1834DD8E0")]
		public void OnHit(float damage, float healthRemaining)
		{
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0000FF30 File Offset: 0x0000E130
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x34DDA20", Offset = "0x34DC020", VA = "0x1834DDA20")]
		public int GetExpressionReplicationInt()
		{
			return 0;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x34DDA30", Offset = "0x34DC030", VA = "0x1834DDA30")]
		public void OnExpressionReplicated(int replicatedExpression)
		{
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x34DDB70", Offset = "0x34DC170", VA = "0x1834DDB70")]
		private void UpdateExpression()
		{
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0000FF48 File Offset: 0x0000E148
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x34DDE00", Offset = "0x34DC400", VA = "0x1834DDE00")]
		private bool UseAnimatedExpressions()
		{
			return default(bool);
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x34DDF00", Offset = "0x34DC500", VA = "0x1834DDF00")]
		private void Update()
		{
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x34DE550", Offset = "0x34DCB50", VA = "0x1834DE550")]
		private void UpdateCurrentExpressionRandom()
		{
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x34DE830", Offset = "0x34DCE30", VA = "0x1834DE830")]
		private void UpdateBlendShapesFromBoneDriver()
		{
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x34DECE0", Offset = "0x34DD2E0", VA = "0x1834DECE0")]
		private void UpdateBlink(bool allowBlinking)
		{
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003556")]
		[Address(RVA = "0x34DEE40", Offset = "0x34DD440", VA = "0x1834DEE40")]
		public PlayerExpressions()
		{
		}

		// Token: 0x04002DF8 RID: 11768
		[Token(Token = "0x4002DF8")]
		private const float MaxViewerDist = 30f;

		// Token: 0x04002DF9 RID: 11769
		[Token(Token = "0x4002DF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerExpressionsSettings _settings;

		// Token: 0x04002DFA RID: 11770
		[Token(Token = "0x4002DFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlayerRaceSystem _raceSystem;

		// Token: 0x04002DFB RID: 11771
		[Token(Token = "0x4002DFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002DFC RID: 11772
		[Token(Token = "0x4002DFC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bone;

		// Token: 0x04002DFD RID: 11773
		[Token(Token = "0x4002DFD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerAnimatorControl _animatorControl;

		// Token: 0x04002DFE RID: 11774
		[Token(Token = "0x4002DFE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<BlendShapeBoneDriver.ShapeDriver> _shapeDrivers;

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _boneDriverMultiplier;

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _skinnedMesh;

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[FieldOffset(Offset = "0x60")]
		private string _currentExpression;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[FieldOffset(Offset = "0x68")]
		private float _currentFaceLayerWeight;

		// Token: 0x04002E03 RID: 11779
		[Token(Token = "0x4002E03")]
		[FieldOffset(Offset = "0x6C")]
		private int _blendShapeCount;

		// Token: 0x04002E04 RID: 11780
		[Token(Token = "0x4002E04")]
		[FieldOffset(Offset = "0x0")]
		public static string ForceExpression;

		// Token: 0x04002E05 RID: 11781
		[Token(Token = "0x4002E05")]
		[FieldOffset(Offset = "0x70")]
		private float _nextExpressionChangeTime;

		// Token: 0x04002E06 RID: 11782
		[Token(Token = "0x4002E06")]
		[FieldOffset(Offset = "0x74")]
		private float _targetFaceLayerWeight;

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		[FieldOffset(Offset = "0x78")]
		private float _nextBlinkTime;

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x80")]
		private PlayerExpressionsSettings.ExpressionEvent _expressionEvent;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0x88")]
		private PlayerExpressionsSettings.EventType _expressionType;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[FieldOffset(Offset = "0x8C")]
		private float _eventStartTime;

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x90")]
		private int _replicationIdx;
	}
}
