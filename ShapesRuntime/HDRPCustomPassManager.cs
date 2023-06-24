using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Shapes
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[ExecuteAlways]
	public class HDRPCustomPassManager : MonoBehaviour
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700015F")]
		public static HDRPCustomPassManager Instance
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x2A37380", Offset = "0x2A35980", VA = "0x182A37380")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x2A37650", Offset = "0x2A35C50", VA = "0x182A37650")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x2A376E0", Offset = "0x2A35CE0", VA = "0x182A376E0")]
		private void Awake()
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x2A37770", Offset = "0x2A35D70", VA = "0x182A37770")]
		public void MakeSureVolumeExistsForInjectionPoint(CustomPassInjectionPoint injPt)
		{
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x2A379C0", Offset = "0x2A35FC0", VA = "0x182A379C0")]
		public HDRPCustomPassManager()
		{
		}

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		private static HDRPCustomPassManager instance;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<CustomPassInjectionPoint, CustomPassVolume> volumes;
	}
}
