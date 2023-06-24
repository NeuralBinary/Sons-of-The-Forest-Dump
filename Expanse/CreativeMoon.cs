using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[Serializable]
	public class CreativeMoon : MonoBehaviour
	{
		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xAC1560", Offset = "0xABFB60", VA = "0x180AC1560")]
		private void Update()
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xAC1810", Offset = "0xABFE10", VA = "0x180AC1810")]
		public CreativeMoon()
		{
		}

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x20")]
		public CelestialBodyBlock m_moonBlock;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x28")]
		public bool m_useTimeOfDay;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x30")]
		public DateTimeBlock m_dateTimeBlock;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 m_direction;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Size of the moon. 1 is physically-accurate.")]
		[Range(0f, 10f)]
		public float m_size;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x48")]
		[Min(0f)]
		[Tooltip("Brightness of the moonlight.")]
		public float m_lightBrightness;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x4C")]
		public Color m_lightTint;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x60")]
		[Min(0f)]
		public Cubemap m_texture;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x68")]
		public Vector3 m_rotation;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x74")]
		public Color m_surfaceTint;
	}
}
