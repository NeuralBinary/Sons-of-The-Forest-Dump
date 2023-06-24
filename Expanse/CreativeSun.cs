using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[Serializable]
	public class CreativeSun : MonoBehaviour
	{
		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xAC1940", Offset = "0xABFF40", VA = "0x180AC1940")]
		private void Update()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xAC1B60", Offset = "0xAC0160", VA = "0x180AC1B60")]
		public CreativeSun()
		{
		}

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x20")]
		public CelestialBodyBlock m_sunBlock;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x28")]
		public bool m_useTimeOfDay;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x30")]
		public DateTimeBlock m_dateTimeBlock;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 m_direction;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Size of the sun. 1 is physically-accurate.")]
		[Range(0f, 10f)]
		public float m_size;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Brightness of the sunlight. 150000 is physically-accurate.")]
		[Min(0f)]
		public float m_lightBrightness;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x4C")]
		public Color m_lightTint;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x5C")]
		[Min(0f)]
		public float m_discBrightness;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x60")]
		public Color m_discTint;
	}
}
