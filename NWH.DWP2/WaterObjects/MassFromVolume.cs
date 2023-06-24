using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[RequireComponent(typeof(WaterObject))]
	public class MassFromVolume : MonoBehaviour
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x26FE040", Offset = "0x26FC640", VA = "0x1826FE040")]
		private void Awake()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x26FE230", Offset = "0x26FC830", VA = "0x1826FE230")]
		public void SetDefaultAsMaterial()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x26FE2D0", Offset = "0x26FC8D0", VA = "0x1826FE2D0")]
		private void Reset()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x26FE2E0", Offset = "0x26FC8E0", VA = "0x1826FE2E0")]
		public void CalculateSimulationMeshVolume()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021A0 File Offset: 0x000003A0
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x26FE610", Offset = "0x26FCC10", VA = "0x1826FE610")]
		public float CalculateAndApplyFromMaterial()
		{
			return 0f;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000021B8 File Offset: 0x000003B8
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x26FE640", Offset = "0x26FCC40", VA = "0x1826FE640")]
		public float CalculateAndApplyFromDensity(float density)
		{
			return 0f;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MassFromVolume()
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		public WaterObjectMaterial material;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x2C")]
		public float mass;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x30")]
		public float volume;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x38")]
		private WaterObject _waterObject;
	}
}
