using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.GPS
{
	// Token: 0x02000707 RID: 1799
	[Token(Token = "0x2000707")]
	[CreateAssetMenu(fileName = "newGPSLocatorIcons", menuName = "Sons/Data/GPSLocatorIcons", order = 0)]
	public class GPSLocatorIcons : ScriptableObject
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DD")]
		public List<GPSLocatorIcons.IconData> IconDataList
		{
			[Token(Token = "0x6002EDA")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x2E2B550", Offset = "0x2E2A550", VA = "0x182E2B550")]
		public GPSLocatorIcons()
		{
		}

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GPSLocatorIcons.IconData> _iconDataList;

		// Token: 0x02000708 RID: 1800
		[Token(Token = "0x2000708")]
		[Serializable]
		public class IconData
		{
			// Token: 0x06002EDC RID: 11996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002EDC")]
			[Address(RVA = "0x2E34FD0", Offset = "0x2E33FD0", VA = "0x182E34FD0")]
			public IconData(GPSLocatorIcons.IconData iconData)
			{
			}

			// Token: 0x04002976 RID: 10614
			[Token(Token = "0x4002976")]
			[FieldOffset(Offset = "0x10")]
			public int _id;

			// Token: 0x04002977 RID: 10615
			[Token(Token = "0x4002977")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D _icon;

			// Token: 0x04002978 RID: 10616
			[Token(Token = "0x4002978")]
			[FieldOffset(Offset = "0x20")]
			public Texture2D _iconOutline;

			// Token: 0x04002979 RID: 10617
			[Token(Token = "0x4002979")]
			[FieldOffset(Offset = "0x28")]
			public Color _iconColor;

			// Token: 0x0400297A RID: 10618
			[Token(Token = "0x400297A")]
			[FieldOffset(Offset = "0x38")]
			public Color _iconOutlineColor;

			// Token: 0x0400297B RID: 10619
			[Token(Token = "0x400297B")]
			[FieldOffset(Offset = "0x48")]
			[FormerlySerializedAs("_color")]
			public Color _backgroundColor;
		}
	}
}
