using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public class SnapToTerrain : MonoBehaviour
	{
		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA8B670", Offset = "0xA89C70", VA = "0x180A8B670")]
		private void Awake()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA8B6D0", Offset = "0xA89CD0", VA = "0x180A8B6D0")]
		private void Start()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA8B730", Offset = "0xA89D30", VA = "0x180A8B730")]
		private void OnEnable()
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA8B740", Offset = "0xA89D40", VA = "0x180A8B740")]
		private void Update()
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA8B750", Offset = "0xA89D50", VA = "0x180A8B750")]
		private void Snap()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SnapToTerrain()
		{
		}

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _alignToSurfaceNormal;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SnapToTerrain.TriggerType _trigger;

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		public enum TriggerType
		{
			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000135")]
			OnAwake,
			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			OnStart,
			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			OnEnable,
			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			OnUpdate
		}
	}
}
