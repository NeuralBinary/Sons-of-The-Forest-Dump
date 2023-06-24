using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public class SphereWaterInteraction : MonoBehaviour
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x17000025")]
		private float Radius
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x9DB3F0", Offset = "0x9D99F0", VA = "0x1809DB3F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9DB4B0", Offset = "0x9D9AB0", VA = "0x1809DB4B0")]
		private void Start()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x9DB9D0", Offset = "0x9D9FD0", VA = "0x1809DB9D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9DC190", Offset = "0x9DA790", VA = "0x1809DC190")]
		private bool LateUpdateCountOverlappingSims(out int simsActive, out int simsPresent)
		{
			return default(bool);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x9DC460", Offset = "0x9DAA60", VA = "0x1809DC460")]
		private Vector3 LateUpdateComputeVelRelativeToWater(OceanRenderer ocean)
		{
			return default(Vector3);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x9DC9E0", Offset = "0x9DAFE0", VA = "0x1809DC9E0")]
		private void LateUpdateSphereWeight(float waterHeight, ref float weight)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x9DCB50", Offset = "0x9DB150", VA = "0x1809DCB50")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x9DCCE0", Offset = "0x9DB2E0", VA = "0x1809DCCE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x9DCEC0", Offset = "0x9DB4C0", VA = "0x1809DCEC0")]
		public SphereWaterInteraction()
		{
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x20")]
		[Range(-1f, 1f)]
		[SerializeField]
		private float _weight;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 2f)]
		[SerializeField]
		private float _weightUpDownMul;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x28")]
		[Header("Limits")]
		[Tooltip("Teleport speed (km/h) - if the calculated speed is larger than this amount, the object is deemed to have teleported and the computed velocity is discarded.")]
		[SerializeField]
		private float _teleportSpeed;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _warnOnTeleport;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Maximum speed clamp (km/h), useful for controlling/limiting wake.")]
		[SerializeField]
		private float _maxSpeed;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _warnOnSpeedClamp;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x38")]
		private FloatingObjectBase _object;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _posLast;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x50")]
		private SampleHeightHelper _sampleHeightHelper;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x58")]
		private SampleFlowHelper _sampleFlowHelper;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x60")]
		private Renderer _renderer;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock _mpb;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x0")]
		private static int sp_velocity;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x4")]
		private static int sp_weight;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x8")]
		private static int sp_simDeltaTime;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0xC")]
		private static int sp_radius;
	}
}
