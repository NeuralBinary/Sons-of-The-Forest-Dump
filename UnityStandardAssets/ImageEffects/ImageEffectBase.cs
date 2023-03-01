using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000313 RID: 787
	[Token(Token = "0x2000313")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		// Token: 0x06001447 RID: 5191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001447")]
		[Address(RVA = "0x2C669B0", Offset = "0x2C659B0", VA = "0x182C669B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CB")]
		protected Material material
		{
			[Token(Token = "0x6001448")]
			[Address(RVA = "0x2C66A50", Offset = "0x2C65A50", VA = "0x182C66A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x2C66930", Offset = "0x2C65930", VA = "0x182C66930", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ImageEffectBase()
		{
		}

		// Token: 0x04001413 RID: 5139
		[Token(Token = "0x4001413")]
		[FieldOffset(Offset = "0x20")]
		public Shader shader;

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0x28")]
		private Material m_Material;
	}
}
