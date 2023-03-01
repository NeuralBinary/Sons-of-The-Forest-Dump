using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000575 RID: 1397
	[Token(Token = "0x2000575")]
	public class ProcessLightProbes : MonoBehaviour
	{
		// Token: 0x0600243E RID: 9278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x2D8BC50", Offset = "0x2D8AC50", VA = "0x182D8BC50")]
		public ProcessLightProbes()
		{
		}

		// Token: 0x04002092 RID: 8338
		[Token(Token = "0x4002092")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3[] _directionsArray;

		// Token: 0x04002093 RID: 8339
		[Token(Token = "0x4002093")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _contrastMidPoint;

		// Token: 0x04002094 RID: 8340
		[Token(Token = "0x4002094")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _contrastAmount;

		// Token: 0x04002095 RID: 8341
		[Token(Token = "0x4002095")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _desaturateAmount;

		// Token: 0x04002096 RID: 8342
		[Token(Token = "0x4002096")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _finalScale;

		// Token: 0x04002097 RID: 8343
		[Token(Token = "0x4002097")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxLights;

		// Token: 0x04002098 RID: 8344
		[Token(Token = "0x4002098")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 _clip;

		// Token: 0x04002099 RID: 8345
		[Token(Token = "0x4002099")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _outputPath;

		// Token: 0x0400209A RID: 8346
		[Token(Token = "0x400209A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Vector3> _minMidMax;

		// Token: 0x0400209B RID: 8347
		[Token(Token = "0x400209B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[ColorUsage(false, true)]
		private Color _ambient;

		// Token: 0x0400209C RID: 8348
		[Token(Token = "0x400209C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[ColorUsage(false, true)]
		private List<Color> _sources;

		// Token: 0x0400209D RID: 8349
		[Token(Token = "0x400209D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<Vector3> _sourcesRaw;

		// Token: 0x0400209E RID: 8350
		[Token(Token = "0x400209E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[ColorUsage(false, true)]
		private List<Color> _minMidMaxColors;

		// Token: 0x0400209F RID: 8351
		[Token(Token = "0x400209F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x040020A0 RID: 8352
		[Token(Token = "0x40020A0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<Collider> _cullingColliders;

		// Token: 0x040020A1 RID: 8353
		[Token(Token = "0x40020A1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<LightProbeGroup> _filterGroups;
	}
}
