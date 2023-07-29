import { ParentProps } from "solid-js";
import "./SiteWrapper.css"


export default function SiteWrapper(props: ParentProps<{}>) {
    return (
        <div class="h-screen clouds"> 
            <div class={`p-14 siteWrapper shadow-md shadow-[navy] h-full`}>{props.children}</div>
        </div>
    );
}

