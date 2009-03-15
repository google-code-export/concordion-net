//--------------------------------------------------------------------------
//	Copyright (c) 1998-2004, Drew Davidson and Luke Blanshard
//  All rights reserved.
//
//	Redistribution and use in source and binary forms, with or without
//  modification, are permitted provided that the following conditions are
//  met:
//
//	Redistributions of source code must retain the above copyright notice,
//  this list of conditions and the following disclaimer.
//	Redistributions in binary form must reproduce the above copyright
//  notice, this list of conditions and the following disclaimer in the
//  documentation and/or other materials provided with the distribution.
//	Neither the name of the Drew Davidson nor the names of its contributors
//  may be used to endorse or promote products derived from this software
//  without specific prior written permission.
//
//	THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
//  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
//  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
//  FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE
//  COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
//  INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
//  BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS
//  OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED
//  AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
//  OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF
//  THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
//  DAMAGE.
//--------------------------------------------------------------------------
namespace ognl
{

/**
 * @author Luke Blanshard (blanshlu@netscape.net)
 * @author Drew Davidson (drew@ognl.org)
 */
class ASTMethod : SimpleNode
{
    private string methodName;

    public ASTMethod(int id) : base(id){
        
    }

    public ASTMethod(OgnlParser p, int id) : base(p, id){
        
    }

      /** Called from parser action. */

	internal void setMethodName( string methodName ) {
        this.methodName = methodName;
    }

    /**
        Returns the method name that this node will call.
     */
    public string getMethodName()
    {
        return methodName;
    }

    protected override object getValueBody( OgnlContext context, object source ) // throws OgnlException
    {
        object[]    args = OgnlRuntime.getObjectArrayPool().create(jjtGetNumChildren());

        try {
            object      result,
                        root = context.getRoot();

            for ( int i = 0, icount = args.Length; i < icount; ++i ) {
                args[i] = children[i].getValue(context, root);
            }
            result = OgnlRuntime.callMethod( context, source, methodName, null, args);
            if (result == null) {
                NullHandler     nh = OgnlRuntime.getNullHandler(OgnlRuntime.getTargetClass(source));

                result = nh.nullMethodResult(context, source, methodName, args);
            }
            return result;
        } finally {
            OgnlRuntime.getObjectArrayPool().recycle(args);
        }
    }

    public override string ToString()
    {
        string      result = methodName;

        result = result + "(";
        if ((children != null) && (children.Length > 0)) {
            for (int i = 0; i < children.Length; i++) {
                if (i > 0) {
                    result = result + ", ";
                }
                result = result + children[i];
            }
        }
        result = result + ")";
        return result;
    }
}
}
