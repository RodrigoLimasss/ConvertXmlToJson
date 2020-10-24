namespace ConvertXmlToJson
{
    public static class XmlSource
    {
        public const string XmlString = @"
            <employees version=""1"">
                <employee>
                    <id>1</id>
                    <firstName>Tom</firstName>
                    <lastName>Cruise</lastName>
                    <photo size=""7"">https://pbs.twimg.com/profile_images/735509975649378305/B81JwLT7.jpg</photo>
                </employee>
                <employee>
                    <id>2</id>
                    <firstName>Maria</firstName>
                    <lastName>Sharapova</lastName>
                    <photo size=""13"">https://pbs.twimg.com/profile_images/3424509849/bfa1b9121afc39d1dcdb53cfc423bf12.jpeg</photo>
                </employee>
                <employee>
                    <id>3</id>
                    <firstName>James</firstName>
                    <lastName>Bond</lastName>
                    <photo size=""12"">https://pbs.twimg.com/profile_images/664886718559076352/M00cOLrh.jpg</photo>
                </employee>
            </employees>";
    }
}
