using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008FC RID: 2300
	[Token(Token = "0x20008FC")]
	[Serializable]
	public class ControllerNodeInfo
	{
		// Token: 0x06004245 RID: 16965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x36335D0", Offset = "0x3631BD0", VA = "0x1836335D0")]
		public ControllerNodeInfo(string name, string path, AnimationClip clip, NodeType nodeType, [Optional] string clipPath)
		{
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x3633740", Offset = "0x3631D40", VA = "0x183633740")]
		public void Add(ControllerNodeInfo controllerNodeInfo)
		{
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x17000855")]
		private bool IsClipType
		{
			[Token(Token = "0x6004247")]
			[Address(RVA = "0x3633870", Offset = "0x3631E70", VA = "0x183633870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x17000856")]
		private Color GetGuiColor
		{
			[Token(Token = "0x6004248")]
			[Address(RVA = "0x3633880", Offset = "0x3631E80", VA = "0x183633880")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		public List<ControllerNodeInfo> GetNodes()
		{
			return null;
		}

		// Token: 0x040045A1 RID: 17825
		[Token(Token = "0x40045A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private NodeType _nodeType;

		// Token: 0x040045A2 RID: 17826
		[Token(Token = "0x40045A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		// Token: 0x040045A3 RID: 17827
		[Token(Token = "0x40045A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _path;

		// Token: 0x040045A4 RID: 17828
		[Token(Token = "0x40045A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip _clip;

		// Token: 0x040045A5 RID: 17829
		[Token(Token = "0x40045A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _clipPath;

		// Token: 0x040045A6 RID: 17830
		[Token(Token = "0x40045A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ControllerNodeInfo> _subNodes;
	}
}
