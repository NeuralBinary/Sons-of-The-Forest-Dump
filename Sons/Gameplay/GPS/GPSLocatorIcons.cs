using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.GPS
{
	// Token: 0x02000855 RID: 2133
	[Token(Token = "0x2000855")]
	[CreateAssetMenu(fileName = "newGPSLocatorIcons", menuName = "Sons/Data/GPSLocatorIcons", order = 0)]
	public class GPSLocatorIcons : ScriptableObject
	{
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E0")]
		public List<GPSLocatorIcons.IconData> IconDataList
		{
			[Token(Token = "0x6003CD4")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x35ACC00", Offset = "0x35AB200", VA = "0x1835ACC00")]
		public GPSLocatorIcons()
		{
		}

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GPSLocatorIcons.IconData> _iconDataList;

		// Token: 0x02000856 RID: 2134
		[Token(Token = "0x2000856")]
		[Serializable]
		public class IconData
		{
			// Token: 0x06003CD6 RID: 15574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003CD6")]
			[Address(RVA = "0x35ACCC0", Offset = "0x35AB2C0", VA = "0x1835ACCC0")]
			public IconData(GPSLocatorIcons.IconData iconData)
			{
			}

			// Token: 0x0400335E RID: 13150
			[Token(Token = "0x400335E")]
			[FieldOffset(Offset = "0x10")]
			public int _id;

			// Token: 0x0400335F RID: 13151
			[Token(Token = "0x400335F")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D _icon;

			// Token: 0x04003360 RID: 13152
			[Token(Token = "0x4003360")]
			[FieldOffset(Offset = "0x20")]
			public Texture2D _iconOutline;

			// Token: 0x04003361 RID: 13153
			[Token(Token = "0x4003361")]
			[FieldOffset(Offset = "0x28")]
			public Color _iconColor;

			// Token: 0x04003362 RID: 13154
			[Token(Token = "0x4003362")]
			[FieldOffset(Offset = "0x38")]
			public Color _iconOutlineColor;

			// Token: 0x04003363 RID: 13155
			[Token(Token = "0x4003363")]
			[FieldOffset(Offset = "0x48")]
			[FormerlySerializedAs("_color")]
			public Color _backgroundColor;
		}
	}
}
