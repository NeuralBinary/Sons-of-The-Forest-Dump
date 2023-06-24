using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000585 RID: 1413
	[Token(Token = "0x2000585")]
	public class ProcessLightProbes : MonoBehaviour
	{
		// Token: 0x0600253D RID: 9533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x339A5B0", Offset = "0x3398BB0", VA = "0x18339A5B0")]
		public ProcessLightProbes()
		{
		}

		// Token: 0x04002166 RID: 8550
		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3[] _directionsArray;

		// Token: 0x04002167 RID: 8551
		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _contrastMidPoint;

		// Token: 0x04002168 RID: 8552
		[Token(Token = "0x4002168")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _contrastAmount;

		// Token: 0x04002169 RID: 8553
		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _desaturateAmount;

		// Token: 0x0400216A RID: 8554
		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _finalScale;

		// Token: 0x0400216B RID: 8555
		[Token(Token = "0x400216B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxLights;

		// Token: 0x0400216C RID: 8556
		[Token(Token = "0x400216C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 _clip;

		// Token: 0x0400216D RID: 8557
		[Token(Token = "0x400216D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _outputPath;

		// Token: 0x0400216E RID: 8558
		[Token(Token = "0x400216E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Vector3> _minMidMax;

		// Token: 0x0400216F RID: 8559
		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[ColorUsage(false, true)]
		private Color _ambient;

		// Token: 0x04002170 RID: 8560
		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[ColorUsage(false, true)]
		private List<Color> _sources;

		// Token: 0x04002171 RID: 8561
		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<Vector3> _sourcesRaw;

		// Token: 0x04002172 RID: 8562
		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[ColorUsage(false, true)]
		private List<Color> _minMidMaxColors;

		// Token: 0x04002173 RID: 8563
		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04002174 RID: 8564
		[Token(Token = "0x4002174")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<Collider> _cullingColliders;

		// Token: 0x04002175 RID: 8565
		[Token(Token = "0x4002175")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<LightProbeGroup> _filterGroups;
	}
}
