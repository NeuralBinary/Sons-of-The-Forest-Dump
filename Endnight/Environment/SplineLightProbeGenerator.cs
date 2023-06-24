using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Splines;

namespace Endnight.Environment
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public class SplineLightProbeGenerator : MonoBehaviour
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045B")]
		[Address(RVA = "0xAA7FB0", Offset = "0xAA65B0", VA = "0x180AA7FB0")]
		public SplineLightProbeGenerator()
		{
		}

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SplineContainer[] _splineContainers;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Vector3> _hitPoints;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxDepth;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _minDistance;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _gizmoRadius;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _gizmoColor;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int _maxDistance;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int _initialRayCount;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int _subRayCount;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _skipInFillPositions;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x5D")]
		[SerializeField]
		private bool _useColliderPositions;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _mergeDistance;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<Vector3> _mergedPoints;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _maxZOffset;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LightProbeGroup _targetGroup;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _autoPushToGroup;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 _lastGizmoPos;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x90")]
		private List<Vector3> _offsetPoints;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _lightProbeMergeDistance;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _radialOffset;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool _drawGizmosSelected;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0xA1")]
		[SerializeField]
		private bool _alwaysDrawGizmos;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _splineStepDistance;
	}
}
