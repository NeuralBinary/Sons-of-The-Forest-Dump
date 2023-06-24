using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x320ADC0", Offset = "0x32093C0", VA = "0x18320ADC0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D3")]
		protected Material material
		{
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x320AF20", Offset = "0x3209520", VA = "0x18320AF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x320B0C0", Offset = "0x32096C0", VA = "0x18320B0C0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ImageEffectBase()
		{
		}

		// Token: 0x04001431 RID: 5169
		[Token(Token = "0x4001431")]
		[FieldOffset(Offset = "0x20")]
		public Shader shader;

		// Token: 0x04001432 RID: 5170
		[Token(Token = "0x4001432")]
		[FieldOffset(Offset = "0x28")]
		private Material m_Material;
	}
}
