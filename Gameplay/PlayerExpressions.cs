using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation.BlendShapes;
using Sons.Wearable.Race;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200068B RID: 1675
	[Token(Token = "0x200068B")]
	[AddComponentMenu("Sons/Gameplay/PlayerExpressions")]
	public class PlayerExpressions : MonoBehaviour
	{
		// Token: 0x06002AD8 RID: 10968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x2DD9940", Offset = "0x2DD8940", VA = "0x182DD9940")]
		private void OnValidate()
		{
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0x2DD9620", Offset = "0x2DD8620", VA = "0x182DD9620")]
		private void OnEnable()
		{
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x2DD9550", Offset = "0x2DD8550", VA = "0x182DD9550")]
		private void OnDisable()
		{
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x2DD9820", Offset = "0x2DD8820", VA = "0x182DD9820")]
		private void OnRaceChanged(PlayerRace.Race race)
		{
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x2DD9760", Offset = "0x2DD8760", VA = "0x182DD9760")]
		public void OnHit(float damage, float healthRemaining)
		{
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0000C528 File Offset: 0x0000A728
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x2DD9540", Offset = "0x2DD8540", VA = "0x182DD9540")]
		public int GetExpressionReplicationInt()
		{
			return default(int);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0x2DD96F0", Offset = "0x2DD86F0", VA = "0x182DD96F0")]
		public void OnExpressionReplicated(int replicatedExpression)
		{
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADF")]
		[Address(RVA = "0x2DDA0B0", Offset = "0x2DD90B0", VA = "0x182DDA0B0")]
		private void UpdateExpression()
		{
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0000C540 File Offset: 0x0000A740
		[Token(Token = "0x6002AE0")]
		[Address(RVA = "0x2DDA690", Offset = "0x2DD9690", VA = "0x182DDA690")]
		private bool UseAnimatedExpressions()
		{
			return default(bool);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE1")]
		[Address(RVA = "0x2DDA270", Offset = "0x2DD9270", VA = "0x182DDA270")]
		private void Update()
		{
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE2")]
		[Address(RVA = "0x2DD9EE0", Offset = "0x2DD8EE0", VA = "0x182DD9EE0")]
		private void UpdateCurrentExpressionRandom()
		{
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE3")]
		[Address(RVA = "0x2DD9A30", Offset = "0x2DD8A30", VA = "0x182DD9A30")]
		private void UpdateBlendShapesFromBoneDriver()
		{
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE4")]
		[Address(RVA = "0x2DD9E00", Offset = "0x2DD8E00", VA = "0x182DD9E00")]
		private void UpdateBlink(bool allowBlinking)
		{
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0x2DDA760", Offset = "0x2DD9760", VA = "0x182DDA760")]
		public PlayerExpressions()
		{
		}

		// Token: 0x04002657 RID: 9815
		[Token(Token = "0x4002657")]
		private const float MaxViewerDist = 30f;

		// Token: 0x04002658 RID: 9816
		[Token(Token = "0x4002658")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerExpressionsSettings _settings;

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlayerRaceSystem _raceSystem;

		// Token: 0x0400265A RID: 9818
		[Token(Token = "0x400265A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bone;

		// Token: 0x0400265C RID: 9820
		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerAnimatorControl _animatorControl;

		// Token: 0x0400265D RID: 9821
		[Token(Token = "0x400265D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<BlendShapeBoneDriver.ShapeDriver> _shapeDrivers;

		// Token: 0x0400265E RID: 9822
		[Token(Token = "0x400265E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _boneDriverMultiplier;

		// Token: 0x0400265F RID: 9823
		[Token(Token = "0x400265F")]
		[FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _skinnedMesh;

		// Token: 0x04002660 RID: 9824
		[Token(Token = "0x4002660")]
		[FieldOffset(Offset = "0x60")]
		private string _currentExpression;

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x68")]
		private float _currentFaceLayerWeight;

		// Token: 0x04002662 RID: 9826
		[Token(Token = "0x4002662")]
		[FieldOffset(Offset = "0x6C")]
		private int _blendShapeCount;

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x0")]
		public static string ForceExpression;

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x70")]
		private float _nextExpressionChangeTime;

		// Token: 0x04002665 RID: 9829
		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x74")]
		private float _targetFaceLayerWeight;

		// Token: 0x04002666 RID: 9830
		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x78")]
		private float _nextBlinkTime;

		// Token: 0x04002667 RID: 9831
		[Token(Token = "0x4002667")]
		[FieldOffset(Offset = "0x80")]
		private PlayerExpressionsSettings.ExpressionEvent _expressionEvent;

		// Token: 0x04002668 RID: 9832
		[Token(Token = "0x4002668")]
		[FieldOffset(Offset = "0x88")]
		private PlayerExpressionsSettings.EventType _expressionType;

		// Token: 0x04002669 RID: 9833
		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x8C")]
		private float _eventStartTime;

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x90")]
		private int _replicationIdx;
	}
}
