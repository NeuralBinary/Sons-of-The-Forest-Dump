using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AddComponentMenu("Sons/Environment/ForceTimeOfDay")]
	public class ForceTimeOfDay : MonoBehaviour
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2D2D930", Offset = "0x2D2BF30", VA = "0x182D2D930")]
		private void OnValidate()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2D2D9C0", Offset = "0x2D2BFC0", VA = "0x182D2D9C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2D2D9D0", Offset = "0x2D2BFD0", VA = "0x182D2D9D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2D2DAB0", Offset = "0x2D2C0B0", VA = "0x182D2DAB0")]
		private void Update()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2D2DAD0", Offset = "0x2D2C0D0", VA = "0x182D2DAD0")]
		private void TryApply()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2D2DC70", Offset = "0x2D2C270", VA = "0x182D2DC70")]
		public ForceTimeOfDay()
		{
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _timeString;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TimeOfDay _timeOfDay;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _useOverrideTimeInsteadOfLocking;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _holdForSeconds;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _holdUntilDisabled;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _revertOnDisable;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x52")]
		private bool _hasApplied;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x53")]
		private bool _hasLock;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		private TimeOfDay _revertValue;
	}
}
