using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	[AddComponentMenu("Sons/Characters/Character Manager")]
	public class CharacterManager : MonoBehaviour
	{
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E9")]
		public static CharacterManager Instance
		{
			[Token(Token = "0x60035A4")]
			[Address(RVA = "0x2E900B0", Offset = "0x2E8F0B0", VA = "0x182E900B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035A5")]
			[Address(RVA = "0x2E900F0", Offset = "0x2E8F0F0", VA = "0x182E900F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x2E8ECC0", Offset = "0x2E8DCC0", VA = "0x182E8ECC0")]
		private void CleanupInstance()
		{
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x60035A7")]
		[Address(RVA = "0x2E8FD90", Offset = "0x2E8ED90", VA = "0x182E8FD90")]
		private bool SetupInstance()
		{
			return default(bool);
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A8")]
		[Address(RVA = "0x2E8EAD0", Offset = "0x2E8DAD0", VA = "0x182E8EAD0")]
		private void Awake()
		{
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x2E8FBC0", Offset = "0x2E8EBC0", VA = "0x182E8FBC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AA")]
		[Address(RVA = "0x2E8FCE0", Offset = "0x2E8ECE0", VA = "0x182E8FCE0")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x0000F738 File Offset: 0x0000D938
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x2E8F920", Offset = "0x2E8E920", VA = "0x182E8F920")]
		public bool DebugCommandAddCharacter(string arguments)
		{
			return default(bool);
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x2E8FFE0", Offset = "0x2E8EFE0", VA = "0x182E8FFE0")]
		private void TryGetFloat(string[] ids, int index, ref float value)
		{
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AD")]
		[Address(RVA = "0x2E90040", Offset = "0x2E8F040", VA = "0x182E90040")]
		private void TryGetInt(string[] ids, int index, ref int value)
		{
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x0000F750 File Offset: 0x0000D950
		[Token(Token = "0x60035AE")]
		[Address(RVA = "0x2E8ED90", Offset = "0x2E8DD90", VA = "0x182E8ED90")]
		public bool DebugAddCharacter(string arguments, bool instantSpawn = false)
		{
			return default(bool);
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x0000F768 File Offset: 0x0000D968
		[Token(Token = "0x60035AF")]
		[Address(RVA = "0x2E8FEF0", Offset = "0x2E8EEF0", VA = "0x182E8FEF0")]
		private bool TryGetCharacterVariation(string id, string variationId, int numSpawned, out CharacterVariation characterVariation)
		{
			return default(bool);
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B0")]
		[Address(RVA = "0x2E8F930", Offset = "0x2E8E930", VA = "0x182E8F930")]
		private CharacterDefinition GetDefinition(string id)
		{
			return null;
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B1")]
		[Address(RVA = "0x2E900A0", Offset = "0x2E8F0A0", VA = "0x182E900A0")]
		public CharacterManager()
		{
		}

		// Token: 0x04002E04 RID: 11780
		[Token(Token = "0x4002E04")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _addCharacterDistance;

		// Token: 0x04002E05 RID: 11781
		[Token(Token = "0x4002E05")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CharacterDefinition> _definitions;
	}
}
