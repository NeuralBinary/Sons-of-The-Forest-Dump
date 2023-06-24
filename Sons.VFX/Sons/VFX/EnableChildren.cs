using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.VFX
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class EnableChildren : MonoBehaviour
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x31708A0", Offset = "0x316EEA0", VA = "0x1831708A0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x3170C10", Offset = "0x316F210", VA = "0x183170C10")]
		private void Awake()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x3170C20", Offset = "0x316F220", VA = "0x183170C20")]
		private void OnDisable()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3170D60", Offset = "0x316F360", VA = "0x183170D60")]
		private static void SetActive(GameObject child, bool value)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x3170E60", Offset = "0x316F460", VA = "0x183170E60")]
		private void OnEnable()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EnableChildren()
		{
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_KeepPercent")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _chance;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _blackList;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _gameObjects;
	}
}
