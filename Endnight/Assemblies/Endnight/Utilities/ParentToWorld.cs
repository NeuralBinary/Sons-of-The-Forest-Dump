using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Assemblies.Endnight.Utilities
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class ParentToWorld : MonoBehaviour
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0xA61BC0", Offset = "0xA601C0", VA = "0x180A61BC0")]
		private void Start()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0xA61D10", Offset = "0xA60310", VA = "0x180A61D10")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0xA61E40", Offset = "0xA60440", VA = "0x180A61E40")]
		private void SetToWorld()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ParentToWorld()
		{
		}

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("doImmediate")]
		private bool _doImmediate;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _destroyWithParent;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x28")]
		private Transform _sourceParent;
	}
}
