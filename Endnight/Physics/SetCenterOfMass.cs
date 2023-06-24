using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public class SetCenterOfMass : MonoBehaviour
	{
		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA9D5E0", Offset = "0xA9BBE0", VA = "0x180A9D5E0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA9D740", Offset = "0xA9BD40", VA = "0x180A9D740")]
		private void Start()
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA9D740", Offset = "0xA9BD40", VA = "0x180A9D740")]
		private void Apply()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SetCenterOfMass()
		{
		}

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoSetFromPivot;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _centerOfMass;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rigidbody _rigidbody;
	}
}
