using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector.Internal
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public interface ISubGroupProviderAttribute
	{
		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		IList<PropertyGroupAttribute> GetSubGroupAttributes();

		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		string RepathMemberAttribute(PropertyGroupAttribute attr);
	}
}
