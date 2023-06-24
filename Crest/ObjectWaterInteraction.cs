using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class ObjectWaterInteraction : MonoBehaviour
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x9D7D50", Offset = "0x9D6350", VA = "0x1809D7D50")]
		private void Start()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9D8320", Offset = "0x9D6920", VA = "0x1809D8320")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x9D8EA0", Offset = "0x9D74A0", VA = "0x1809D8EA0")]
		public ObjectWaterInteraction()
		{
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _weightUpDownMul;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Teleport speed (km/h) - if the calculated speed is larger than this amount, the object is deemed to have teleported and the computed velocity is discarded.")]
		private float _teleportSpeed;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _warnOnTeleport;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("Maximum speed clamp (km/h), useful for controlling/limiting wake.")]
		private float _maxSpeed;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _warnOnSpeedClamp;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _velocityPositionOffset;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x38")]
		private FloatingObjectBase _boat;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _posLast;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 _localOffset;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x58")]
		private SampleFlowHelper _sampleFlowHelper;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x60")]
		private Renderer _renderer;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock _mpb;
	}
}
